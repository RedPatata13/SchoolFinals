using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finals.Data.Configuration
{
    public class GradesClassificationConfiguration : IEntityTypeConfiguration<GradesClassification>
    {
        public void Configure(EntityTypeBuilder<GradesClassification> builder)
        {
            builder.HasKey(c => c.GradesClassificationId);

            builder.Property(c => c.GradesClassificationId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Value)
                .IsRequired()
                .HasDefaultValue(-1);

            builder.Property(c => c.Depth)
                .IsRequired()
                .HasDefaultValue(0);

            builder.HasOne(c => c.Parent)
                .WithMany(p => p.Children)
                .HasForeignKey(c => c.ParentId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);

            builder.HasMany(c => c.Children)
                .WithOne(c => c.Parent)
                .HasForeignKey(c => c.ParentId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);
        }
    }
}
