using EleventhProject.Server.Infrastructure.Entities.DonationHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class DonationHistoryConfiguration : IEntityTypeConfiguration<DonationHistoryEntity>
{
    public void Configure(EntityTypeBuilder<DonationHistoryEntity> builder)
    {
        builder
            .ToTable("donation_history")
            .HasKey(donationHistory => donationHistory.Id);

        /*builder
            .Property(donationHistory => donationHistory.Recipient)
            .IsRequired()
            .HasColumnName("recipient_id");

        builder
            .Property(donationHistory => donationHistory.Donor)
            .IsRequired()
            .HasColumnName("donor_id");*/

        builder
            .Property(donationHistory => donationHistory.Date)
            .IsRequired()
            .HasColumnName("date");

        builder
            .Property(donationHistory => donationHistory.IsActive)
            .IsRequired()
            .HasColumnName("is_active");
    }
}