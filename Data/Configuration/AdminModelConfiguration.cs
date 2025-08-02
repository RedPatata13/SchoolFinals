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
    public class AdminModelConfiguration : IEntityTypeConfiguration<AdminModel>
    {
        public void Configure(EntityTypeBuilder<AdminModel> builder)
        {
            builder.HasKey(a => a.AdminID);

            builder.Property(a => a.AdminID).IsRequired().HasMaxLength(50);

            builder.HasOne(a => a.User).WithOne()
                .HasForeignKey<AdminModel>(a => a.UserID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
