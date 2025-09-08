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
    public class AssignedCourseGradeConfiguration : IEntityTypeConfiguration<AssignedCourseGrade>
    {
        public void Configure(EntityTypeBuilder<AssignedCourseGrade> builder)
        {
            builder.HasKey(acg => acg.GradeId);
            builder.Property(acg => acg.GradeId).IsRequired().HasMaxLength(50);

            builder.HasOne(acg => acg.AssignedCourse)
                   .WithMany()
                   .HasForeignKey(acg => acg.AssignedCourseId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(acg => acg.Student)
                     .WithMany()
                     .HasForeignKey(acg => acg.StudentId)
                     .IsRequired()
                     .OnDelete(DeleteBehavior.Restrict);

            builder.Property(acg => acg.Grade)
                     .IsRequired()
                     .HasConversion(
                          v => CourseGradeTranslator.TranslateFromCourseGrade(v),
                          v => CourseGradeTranslator.TranslateToCourseGrade(v))
                     .HasMaxLength(20);

            builder.Property(acg => acg.DateAssigned)
                        .IsRequired()
                        .HasDefaultValue(DateTime.MinValue);

            builder.HasOne(acg => acg.Registration)
                .WithOne()
                .HasForeignKey<AssignedCourseGrade>(acg => acg.RegistrationId)
                .IsRequired(false);
        }
    }
}
