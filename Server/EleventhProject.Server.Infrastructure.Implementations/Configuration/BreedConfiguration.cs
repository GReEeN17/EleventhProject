using EleventhProject.Server.Infrastructure.Entities.Breed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class BreedConfiguration : IEntityTypeConfiguration<BreedEntity>
{
    public void Configure(EntityTypeBuilder<BreedEntity> builder)
    {
        builder
            .ToTable("breed")
            .HasKey(breed => breed.Id);

        builder
            .Property(breed => breed.Title)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("title");

        builder
            .Property(breed => breed.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}