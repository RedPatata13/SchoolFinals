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
    public class ClassBatchModelConfiguration : IEntityTypeConfiguration<ClassBatchModel>
    {
        public void Configure(EntityTypeBuilder<ClassBatchModel> builder)
        {
            builder.HasKey(c => c.BatchId);
            builder.Property(c => c.BatchId)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.BatchName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.DateStart)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);

            builder.Property(c => c.DateEnd)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);

            builder.Property(c => c.ClassBatchStatus)
                .HasConversion<string>()
                .HasDefaultValue(ClassBatchStatus.Default);

            //builder.HasOne(c => c.ClassSection)
            //    .WithMany(b => b.Batches)
            //    .HasForeignKey(c => c.ClassSectionId)
            //    .IsRequired();

            builder.HasMany(c => c.ClassEntries)
                .WithOne(e => e.ClassBatch)
                .IsRequired();

        }
    }
}
