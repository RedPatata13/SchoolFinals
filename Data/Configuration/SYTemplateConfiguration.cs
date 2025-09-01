using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Services.SY_Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finals.Data.Configuration
{
    public class SYTemplateConfiguration : IEntityTypeConfiguration<SYTemplate>
    {
        public void Configure(EntityTypeBuilder<SYTemplate> builder)
        {
            builder.HasKey(builder => builder.TemplateId);
            builder.Property(builder => builder.TemplateId).IsRequired().HasMaxLength(50);
            builder.Property(builder => builder.TemplateName).IsRequired().HasMaxLength(100);
            builder.Property(builder => builder.TermNames)
                   .HasConversion(
                       v => string.Join(',', v),
                       v => v.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList()
                   )
                   .IsRequired();
            builder.Property(builder => builder.ExtraTerms)
                    .HasConversion(
                          v => System.Text.Json.JsonSerializer.Serialize(v, (System.Text.Json.JsonSerializerOptions?)null),
                          v => System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(v, (System.Text.Json.JsonSerializerOptions?)null) ?? new Dictionary<string, string>()
                     )
                     .IsRequired();
        }
    }
}
