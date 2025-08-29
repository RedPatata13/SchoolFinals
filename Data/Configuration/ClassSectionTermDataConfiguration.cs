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
    public class ClassSectionTermDataConfiguration : IEntityTypeConfiguration<ClassSectionTermDataModel>
    {
        public void Configure(EntityTypeBuilder<ClassSectionTermDataModel> builder)
        {
            builder.HasKey(c => c.ClassSectionTermDataId);
            builder.Property(c => c.ClassSectionTermDataId)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(c => c.ClassSection)
                .WithMany(cs => cs.TermData)
                .HasForeignKey(c => c.ClassSectionId)
                .IsRequired();

            builder.HasOne(c => c.Term)
                .WithMany()
                .HasForeignKey(c => c.TermId)
                .IsRequired();

            builder.HasOne(c => c.SchoolYear)
                .WithMany()
                .HasForeignKey(c => c.SchoolYearId)
                .IsRequired();

            builder.HasMany(c => c.AssignedCourses)
                .WithOne(ac => ac.Term)
                .HasForeignKey(ac => ac.TermId)
                .IsRequired(false);



        }
    }
}
