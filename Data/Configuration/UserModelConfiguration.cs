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
    public class UserModelConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(u => u.UserID);

            builder.Property(u => u.UserID)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(u => u.UserEmail)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.Property(u => u.UserPassword)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.UserRole)
                .IsRequired()
                .HasMaxLength (50);

            builder.Property(u => u.DateCreated)
                .IsRequired()
                .HasDefaultValue(DateTime.MinValue);

            builder.HasOne(u => u.Creator)
                .WithMany()
                .HasForeignKey(u => u.CreatorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.Property(u => u.IsActivated);
        }
    }
}
