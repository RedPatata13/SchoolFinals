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
    public class CourseTemplateModelConfiguration : IEntityTypeConfiguration<CourseTemplateModel>
    {
        public void Configure(EntityTypeBuilder<CourseTemplateModel> builder)
        {
            builder.HasKey(ct => ct.TemplateId);
            builder.Property(ct => ct.TemplateId)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(ct => ct.TemplateName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(ct => ct.DateCreated)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);

            builder.HasOne(ct => ct.Creator)
                .WithMany()
                .HasForeignKey(ct => ct.CreatorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ct => ct.Program)
                .WithMany(p => p.courseTemplates)
                .HasForeignKey(ct => ct.ProgramId)
                .IsRequired();

            builder.HasMany(ct => ct.Items)
                .WithOne(cti => cti.Template)
                .HasForeignKey(cti => cti.TemplateId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
