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
    public class GradesTreeConfiguration : IEntityTypeConfiguration<GradesTreeModel>
    {
        public void Configure(EntityTypeBuilder<GradesTreeModel> builder)
        {
            builder.HasKey(gt => gt.TreeId);
            builder.Property(gt => gt.TreeId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(gt => gt.TreeName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(gt => gt.DateCreated)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);

            builder.Property(gt => gt.TreeType) 
                .IsRequired()
                .HasDefaultValue(GradesTreeType.Default);

            builder.HasOne(gt => gt.Root)
                .WithMany()
                .HasForeignKey(gt => gt.RootId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
