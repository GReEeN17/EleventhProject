using EleventhProject.Server.Infrastructure.Entities.PetType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class PetTypeConfiguration : IEntityTypeConfiguration<PetTypeEntity>
{
    public void Configure(EntityTypeBuilder<PetTypeEntity> builder)
    {
        builder
            .ToTable("pet_type")
            .HasKey(petType => petType.Id);

        builder
            .Property(petType => petType.Title)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("title");

        builder
            .Property(petType => petType.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}