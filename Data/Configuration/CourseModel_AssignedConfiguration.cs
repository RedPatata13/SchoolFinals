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
    public class CourseModel_AssignedConfiguration : IEntityTypeConfiguration<CourseModel_Assigned>
    {
        public void Configure(EntityTypeBuilder<CourseModel_Assigned> builder)
        {
            builder.HasKey(builder => builder.AssignedCourseModelId);

            builder.Property(builder => builder.AssignedCourseModelId)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(c => c.Course)
                .WithMany()
                .HasForeignKey(c => c.CourseId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(c => c.AssignedBy)
                .WithMany()
                .HasForeignKey(c => c.AssignedId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(c => c.Teacher)
                .WithMany()
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.HasOne(c => c.Section)
                .WithMany()
                .HasForeignKey(c => c.SectionId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(c => c.DateAssigned)
                .HasDefaultValue(DateTime.MinValue)
                .IsRequired();

            builder.HasMany(c => c.Schedules)
                .WithOne(s => s.AssignedCourseModel)
                .HasForeignKey(s => s.AssignedCourseModelId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);
        }
    }
}
