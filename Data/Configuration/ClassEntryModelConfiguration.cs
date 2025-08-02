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
    public class ClassEntryModelConfiguration : IEntityTypeConfiguration<ClassEntryModel>
    {
        public void Configure(EntityTypeBuilder<ClassEntryModel> builder)
        {
            builder.HasKey(e => e.EntryId);
            builder.Property(e => e.EntryId)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.EntryDate)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);

            builder.HasOne(e => e.ClassSection)
                .WithMany()
                .HasForeignKey(e => e.ClassSectionId)
                .IsRequired();

            builder.HasOne(e => e.ClassBatch)
                .WithMany(b => b.ClassEntries)
                .HasForeignKey(e => e.BatchId)
                .IsRequired();

            builder.HasOne(e => e.Student)
                .WithMany()
                .HasForeignKey(e => e.StudentId)
                .IsRequired();
        }
    }
}
