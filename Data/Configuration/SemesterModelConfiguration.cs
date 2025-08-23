using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finals.Data.Configuration
{
    public class SemesterModelConfiguration : IEntityTypeConfiguration<SemesterModel>
    {
        public void Configure(EntityTypeBuilder<SemesterModel> builder)
        {
            builder.HasKey(s => s.SemesterId);
            builder.Property(s => s.SemesterId).IsRequired().HasMaxLength(30);
            builder.Property(s => s.SemesterName).IsRequired().HasMaxLength(50);
            builder.Property(s => s.DateCreated).IsRequired().HasDefaultValue(DateTime.MinValue);
            builder.Property(s => s.DateStart).IsRequired().HasDefaultValue(DateTime.MinValue);
            builder.Property(s => s.DateEnd).IsRequired().HasDefaultValue(DateTime.MinValue);
            builder.Property(s => s.Status).IsRequired().HasDefaultValue(SemesterStatus.Preparatory);
            builder.Property(s => s.IsActive).IsRequired().HasDefaultValue(false);
            builder.HasOne(s => s.SchoolYear).WithMany(sy => sy.Semesters).HasForeignKey(s => s.SchoolYearId);
            builder.HasMany(s => s.ExtraSemesters)
                   .WithOne(s => s.StandardSemester)
                   .HasForeignKey(s => s.StandardSemesterId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
