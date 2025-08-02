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
    public class StudentModelConfiguration : IEntityTypeConfiguration<StudentModel>
    {
        public void Configure(EntityTypeBuilder<StudentModel> builder)
        {
            builder.HasKey(s => s.StudentID);

            builder.Property(s => s.StudentID).IsRequired().HasMaxLength(50);

            builder.HasOne(s => s.User).WithOne()
                .HasForeignKey<StudentModel>(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
