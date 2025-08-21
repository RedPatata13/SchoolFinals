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
        public class SchoolYearModelConfiguration : IEntityTypeConfiguration<SchoolYearModel>
        {
            public void Configure(EntityTypeBuilder<SchoolYearModel> builder)
            {
                builder.HasKey(sy => sy.SchoolYearId);
                builder.Property(sy => sy.SchoolYearId).IsRequired().HasMaxLength(50);
                builder.Property(sy => sy.Name).IsRequired().HasMaxLength(50);
                builder.Property(sy => sy.IsCurrent).IsRequired();
                builder.Property(sy => sy.IsRegistrationOpen).IsRequired();
                builder.Property(sy => sy.SchoolYearType).IsRequired().HasDefaultValue(SchoolYearType.NotSet);
                builder.HasMany(sy => sy.Semesters).WithOne(s => s.SchoolYear).HasForeignKey(s => s.SchoolYearId);

                builder.Property(sy => sy.StartDate).IsRequired();
                builder.Property(sy => sy.EndDate).IsRequired();
            }
        }
    }
