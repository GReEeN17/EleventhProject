using EleventhProject.Server.Infrastructure.Entities.DonorSearchCard;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class DonorSearchCardConfiguration : IEntityTypeConfiguration<DonorSearchCardEntity>
{
    public void Configure(EntityTypeBuilder<DonorSearchCardEntity> builder)
    {
        builder
            .ToTable("donor_search_card")
            .HasKey(donorSearchCard => donorSearchCard.Id);

        /*builder
            .Property(donorSearchCard => donorSearchCard.Creator)
            .IsRequired()
            .HasColumnName("creator");

        builder
            .Property(donorSearchCard => donorSearchCard.Clinic)
            .IsRequired()
            .HasColumnName("clinic");*/

        builder
            .Property(donorSearchCard => donorSearchCard.Reason)
            .IsRequired()
            .HasMaxLength(1024)
            .HasColumnName("reason");

        builder
            .Property(donorSearchCard => donorSearchCard.BloodAmount)
            .IsRequired()
            .HasColumnName("blood_amount");

        builder
            .Property(donorSearchCard => donorSearchCard.EndDate)
            .IsRequired()
            .HasColumnName("end_date");

        builder
            .Property(donorSearchCard => donorSearchCard.IsUrgent)
            .IsRequired()
            .HasColumnName("is_required");

        builder
            .Property(donorSearchCard => donorSearchCard.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}