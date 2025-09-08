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
    public class AssignedCourseRegistrationModelConfiguration : IEntityTypeConfiguration<AssignedCourseRegistration>
    {
        public void Configure(EntityTypeBuilder<AssignedCourseRegistration> builder)
        {
            builder.HasKey(acr => acr.AssignedCourseRegistrationId);
            builder.Property(acr => acr.AssignedCourseRegistrationId)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(acr => acr.AssignedCourse)
                .WithMany(ac => ac.Registrations)
                .HasForeignKey(acr => acr.AssignedCourseId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(acr => acr.Student)
                .WithMany()
                .HasForeignKey(acr => acr.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(acr => acr.RegistrationDate)
                .HasDefaultValue(DateTime.MinValue)
                .IsRequired();

            builder.HasOne(acr => acr.AssignedCourseGrade)
                .WithOne()
                .HasForeignKey<AssignedCourseRegistration>(acr => acr.AssignedCourseGradeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
