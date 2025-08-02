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
    public class CourseTemplateItemModelConfiguration : IEntityTypeConfiguration<CourseTemplateItem>
    {
        public void Configure(EntityTypeBuilder<CourseTemplateItem> builder)
        {
            builder.HasKey(cti => cti.ItemId);
            builder.Property(cti => cti.ItemId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(cti => cti.DateAssigned)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);

            builder.Property(cti => cti.Units)
                .IsRequired()
                .HasDefaultValue(-1);

            builder.HasOne(cti => cti.Assigner)
                .WithMany()
                .HasForeignKey(cti => cti.AssignerId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(cti => cti.Course)
                .WithMany()
                .HasForeignKey(cti => cti.CourseId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(cti => cti.Template)
                .WithMany(t => t.Items)
                .HasForeignKey(cti => cti.TemplateId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
