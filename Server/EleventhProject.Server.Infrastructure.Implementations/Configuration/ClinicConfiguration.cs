using EleventhProject.Server.Infrastructure.Entities.Clinic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class ClinicConfiguration : IEntityTypeConfiguration<ClinicEntity>
{
    public void Configure(EntityTypeBuilder<ClinicEntity> builder)
    {
        builder
            .ToTable("clinic")
            .HasKey(clinic => clinic.Id);

        builder
            .Property(clinic => clinic.Title)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("title");

        builder
            .Property(clinic => clinic.Address)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("address");

        /*builder
            .Property(clinic => clinic.City)
            .IsRequired()
            .HasColumnName("city_id");*/

        builder
            .Property(clinic => clinic.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}