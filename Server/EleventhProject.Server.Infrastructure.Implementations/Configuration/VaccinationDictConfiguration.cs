using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class VaccinationDictConfiguration : IEntityTypeConfiguration<VaccinationDictEntity>
{
    public void Configure(EntityTypeBuilder<VaccinationDictEntity> builder)
    {
        builder
            .ToTable("vaccination_dict")
            .HasKey(vaccinationDict => vaccinationDict.Id);

        builder
            .Property(vaccinationDict => vaccinationDict.Title)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("title");

        builder
            .Property(vaccinationDict => vaccinationDict.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}