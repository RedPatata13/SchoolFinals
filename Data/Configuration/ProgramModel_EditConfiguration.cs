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
    public class ProgramModel_EditConfiguration : IEntityTypeConfiguration<ProgramModel_Edits>
    {
        public void Configure(EntityTypeBuilder<ProgramModel_Edits> builder)
        {
            builder.HasKey(builder => builder.Edit_ID);

            builder.Property(builder => builder.Edit_ID)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Edit)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(e => e.EditedBy)
                .WithMany()
                .HasForeignKey(e => e.EditorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.ProgramEdited)
                .WithMany()
                .HasForeignKey(e => e.ProgramId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.EditedAt)
                .IsRequired();


            builder.ToTable("programmodel_edits");
        }
    }
}
