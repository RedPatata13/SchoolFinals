using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Finals.Models;

namespace Finals.Data.Configuration
{
    public class TeacherModelConfiguration : IEntityTypeConfiguration<TeacherModel>
    {
        public void Configure(EntityTypeBuilder<TeacherModel> builder)
        {
            builder.HasKey(t => t.TeacherID);

            builder.Property(t => t.TeacherID).IsRequired().HasMaxLength(50);
            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.MiddleName)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(t => t.User).WithOne()
                .HasForeignKey<TeacherModel>(t => t.UserID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
