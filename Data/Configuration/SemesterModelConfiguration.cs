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

            builder.HasOne(s => s.SchoolYear).WithMany(sy => sy.Semesters).HasForeignKey(s => s.SchoolYearId);
        }
    }
}
