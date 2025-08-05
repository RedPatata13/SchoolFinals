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
    public class CourseModelConfiguration : IEntityTypeConfiguration<CourseModel>
    {
        public void Configure(EntityTypeBuilder<CourseModel> builder)
        {
            builder.HasKey(c => c.CourseId);
            builder.Property(c => c.CourseId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.CourseName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.DateCreated)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);

            builder.Property(c => c.DefaultUnits)
                .IsRequired()
                .HasDefaultValue(-1);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(c => c.Creator)
                .WithMany()
                .HasForeignKey(c => c.CreatorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
