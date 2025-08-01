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
    public class ClassSectionEditConfiguration : IEntityTypeConfiguration<ClassSectionEditLog>
    {
        public void Configure(EntityTypeBuilder<ClassSectionEditLog> builder)
        {
            builder.HasKey(log => log.LogId);
            builder.Property(log => log.LogId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(log => log.EditDateTime)
                .IsRequired();

            builder.Property(log => log.EditDescription)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.HasOne(log => log.Section)
                .WithMany()
                .HasForeignKey(log => log.SectionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(log => log.EditedByUser)
                .WithMany()
                .HasForeignKey(log => log.EditedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(log => log.EditType)
                .IsRequired();
        }
    }
}
