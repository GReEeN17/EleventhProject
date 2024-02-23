using EleventhProject.Server.Infrastructure.Entities.City;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class CityConfiguration : IEntityTypeConfiguration<CityEntity>
{
    public void Configure(EntityTypeBuilder<CityEntity> builder)
    {
        builder
            .ToTable("city")
            .HasKey(city => city.Id);

        builder
            .Property(city => city.Title)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("title");

        builder
            .Property(city => city.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}