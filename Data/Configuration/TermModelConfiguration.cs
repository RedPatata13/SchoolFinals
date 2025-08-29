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
    public class TermModelConfiguration : IEntityTypeConfiguration<TermModel>
    {
        public void Configure(EntityTypeBuilder<TermModel> builder)
        {
            builder.HasKey(s => s.TermId);
            builder.Property(s => s.TermId).IsRequired().HasMaxLength(30);
            builder.Property(s => s.TermName).IsRequired().HasMaxLength(50);
            builder.Property(s => s.DateCreated).IsRequired().HasDefaultValue(DateTime.MinValue);
            builder.Property(s => s.DateStart).IsRequired().HasDefaultValue(DateTime.MinValue);
            builder.Property(s => s.DateEnd).IsRequired().HasDefaultValue(DateTime.MinValue);
            builder.Property(s => s.Status).IsRequired().HasDefaultValue(TermStatus.Preparatory);
            builder.Property(s => s.TermType).IsRequired().HasDefaultValue(TermType.Standard);
            builder.Property(s => s.IsActive).IsRequired().HasDefaultValue(false);
            builder.HasOne(s => s.SchoolYear).WithMany(sy => sy.Terms).HasForeignKey(s => s.SchoolYearId);
            builder.HasMany(s => s.ExtraTerms)
                   .WithOne(s => s.StandardTerm)
                   .HasForeignKey(s => s.StandardTermId)
                   .OnDelete(DeleteBehavior.Cascade);
            //builder.Property
            builder.ToTable("Terms");
        }
    }
}
