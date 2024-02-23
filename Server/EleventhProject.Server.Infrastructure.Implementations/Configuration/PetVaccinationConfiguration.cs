using EleventhProject.Server.Infrastructure.Entities.PetVaccination;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class PetVaccinationConfiguration : IEntityTypeConfiguration<PetVaccinationEntity>
{
    public void Configure(EntityTypeBuilder<PetVaccinationEntity> builder)
    {
        builder
            .ToTable("pet_vaccination")
            .HasKey(petVaccination => petVaccination.Id);

        /*builder
            .Property(petVaccination => petVaccination.VaccinationDict)
            .IsRequired()
            .HasColumnName("vaccination_dict_id");

        builder
            .Property(petVaccination => petVaccination.Pet)
            .IsRequired()
            .HasColumnName("pet_id");*/

        builder
            .Property(petVaccination => petVaccination.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}