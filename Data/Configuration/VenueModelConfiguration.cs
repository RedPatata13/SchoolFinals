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
    public class VenueModelConfiguration : IEntityTypeConfiguration<VenueModel>
    {
        public void Configure(EntityTypeBuilder<VenueModel> builder)
        {
            builder.HasKey(v => v.VenueId);
            builder.Property(v => v.VenueId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(v => v.Location)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(v => v.Day)
                .IsRequired()
                .HasDefaultValue(Models.Day.NotSet);

            builder.HasOne(v => v.AssignedCourseModel)
                .WithMany()
                .HasForeignKey(v => v.AssignedCourseModelId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
