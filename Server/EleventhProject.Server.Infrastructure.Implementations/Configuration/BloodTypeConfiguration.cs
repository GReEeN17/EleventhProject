using EleventhProject.Server.Infrastructure.Entities.BloodType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class BloodTypeConfiguration : IEntityTypeConfiguration<BloodTypeEntity>
{
    public void Configure(EntityTypeBuilder<BloodTypeEntity> builder)
    {
        builder
            .ToTable("blood_type")
            .HasKey(bloodType => bloodType.Id);

        builder
            .Property(bloodType => bloodType.Title)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("title");

        builder
            .Property(bloodType => bloodType.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}