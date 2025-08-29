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
    public class SchoolYearRegistrationConfiguration : IEntityTypeConfiguration<SchoolYearRegistration>
    {
        public void Configure(EntityTypeBuilder<SchoolYearRegistration> builder)
        {
            builder.HasKey(s => s.SYRegistrationId);
            builder.Property(s => s.SYRegistrationId)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(s => s.SchoolYear)
                .WithMany(sy => sy.SchoolYearEntrees)
                .HasForeignKey(s => s.SchoolYearId)
                .IsRequired();

            builder.HasOne(s => s.Student)
                .WithMany()
                .HasForeignKey(s => s.UserId)
                .IsRequired();

            builder.Property(s => s.RegistrationDate)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);
        }
    }
}
