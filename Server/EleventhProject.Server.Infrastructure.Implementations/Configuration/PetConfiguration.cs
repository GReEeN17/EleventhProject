using EleventhProject.Server.Infrastructure.Entities.Pet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class PetConfiguration : IEntityTypeConfiguration<PetEntity>
{
    public void Configure(EntityTypeBuilder<PetEntity> builder)
    {
        builder
            .ToTable("pet")
            .HasKey(pet => pet.Id);

        /*builder
            .Property(pet => pet.Owner)
            .IsRequired()
            .HasColumnName("owner_id");

        builder
            .Property(pet => pet.PetType)
            .IsRequired()
            .HasColumnName("pet_type_id");

        builder
            .Property(pet => pet.Breed)
            .IsRequired()
            .HasColumnName("breed_id");

        builder
            .Property(pet => pet.BloodType)
            .IsRequired()
            .HasColumnName("blood_type_id");*/

        builder
            .Property(pet => pet.Name)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("name");

        builder
            .Property(pet => pet.Age)
            .IsRequired()
            .HasColumnName("age");

        builder
            .Property(pet => pet.Weight)
            .IsRequired()
            .HasColumnName("weight");

        builder
            .Property(pet => pet.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}