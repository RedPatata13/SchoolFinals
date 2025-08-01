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
    public class ClassSectionTransitionModelConfiguration : IEntityTypeConfiguration<ClassSectionTransitionModel>
    {
        public void Configure(EntityTypeBuilder<ClassSectionTransitionModel> builder)
        {
            builder.HasKey(builder => builder.TransitionId);
            builder.Property(builder => builder.TransitionId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(cs => cs.TransitionPercentage)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.HasOne(cs => cs.FromSection)
                .WithMany(cs => cs.IncomingTransition)
                .HasForeignKey(cs => cs.FromSectionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(cs => cs.ToSection)
                .WithMany()
                .HasForeignKey(cs => cs.ToSectionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("ClassSectionTransitions");
        }
    }
}
