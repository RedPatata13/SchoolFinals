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
    public class ClassSectionConfiguration : IEntityTypeConfiguration<ClassSectionModel>
    {
        public void Configure(EntityTypeBuilder<ClassSectionModel> builder)
        {
            builder.HasKey(c => c.SectionID);
            builder.Property(c => c.SectionID)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.SectionName)
                .IsRequired()
                .HasMaxLength(50);

            //builder.Property(c => c.CurrentBatch)

            builder.HasMany(c => c.IncomingTransition)
                .WithOne(t => t.FromSection)
                .HasForeignKey(t => t.FromSectionId)
                .IsRequired();

            builder.HasOne(c => c.Program)
                .WithMany(p => p.ClassSections)
                .HasForeignKey(c => c.ProgramId)
                .IsRequired();


            builder.HasMany(c => c.Batches)
                .WithOne(b => b.ClassSection)
                .HasForeignKey(b => b.ClassSectionId)
                .IsRequired();

            builder.HasMany(c => c.DefaultCourses)
                .WithMany()
                .UsingEntity(j => j.ToTable("ClassSectionDefaultCourses"));


            builder.ToTable("ClassSections");
        }
    }
}
