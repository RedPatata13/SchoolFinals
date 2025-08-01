using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Y2S1_INC_Compliance_proj.Models;

public class TestModelConfiguration : IEntityTypeConfiguration<TestModel>
{
    public void Configure(EntityTypeBuilder<TestModel> builder)
    {
        builder.HasKey(t => t.ID);  // Primary Key

        builder.Property(t => t.ID)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.ToTable("TestModels");  // Optional: Explicit table name
    }
}