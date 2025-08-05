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
    public class GradedTaskConfiguration : IEntityTypeConfiguration<GradedTaskModel>
    {
        public void Configure(EntityTypeBuilder<GradedTaskModel> builder)
        {
            builder.HasKey(gt => gt.TaskId);

            builder.Property(gt => gt.TaskId)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(gt => gt.TaskName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(gt => gt.CreatedAt)
                .HasDefaultValue(DateTime.MinValue)
                .IsRequired();

            builder.Property(gt => gt.DueDate) 
                .HasDefaultValue(DateTime.MinValue)
                .IsRequired();

            builder.Property(gt => gt.Description)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(gt => gt.Status)
                .IsRequired()
                .HasDefaultValue(GradedTaskStatus.Default);

            builder.HasOne(gt => gt.Creator)
                .WithMany()
                .HasForeignKey(gt => gt.CreatorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(gt => gt.AssignedCourse)
                .WithMany()
                .HasForeignKey(gt => gt.AssignedCourseId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(gt => gt.GradesClassification)
                .WithMany()
                .HasForeignKey(gt => gt.ClassificationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(gt => gt.Items)
                .WithOne(at => at.Task)
                .HasForeignKey(at => at.TaskId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
