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
    public class ProgramModelConfiguration : IEntityTypeConfiguration<ProgramModel>
    {
        public void Configure(EntityTypeBuilder<ProgramModel> builder)
        {
            builder.HasKey(p => p.ProgramId);
            builder.Property(p => p.ProgramId)
                .IsRequired()
                .HasMaxLength(50);  

            builder.Property(p => p.ProgramName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.IsOpen)
                .IsRequired();

            builder.HasOne(p => p.CreatedBy)
                .WithMany()
                .HasForeignKey(p => p.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.LastEditedBy)
                .WithMany()
                .HasForeignKey(p => p.LastEditorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.ProgramDescription)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.CreatedAt)
                .IsRequired();

            builder.HasMany(p => p.ClassSections)
                .WithOne(c => c.Program)
                .HasForeignKey(c => c.ProgramId)
                .IsRequired();

            builder.ToTable("programmodel");
        }
    }
}
