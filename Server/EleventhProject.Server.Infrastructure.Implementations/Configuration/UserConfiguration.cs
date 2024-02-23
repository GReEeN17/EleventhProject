using EleventhProject.Server.Infrastructure.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleventhProject.Server.Infrastructure.Implementations.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder
            .ToTable("user")
            .HasKey(user => user.Id);

        /*builder
            .Property(user => user.City)
            .IsRequired()
            .HasColumnName("city");*/

        builder
            .Property(user => user.UserName)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("username");

        builder
            .Property(user => user.Password)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("password");

        builder
            .Property(user => user.PhoneNumber)
            .IsRequired()
            .HasColumnName("phone_number");

        builder
            .Property(user => user.Surname)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("surname");

        builder
            .Property(user => user.Name)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("name");

        builder
            .Property(user => user.MiddleName)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("middle_name");

        builder
            .Property(user => user.NotReadyForDonation)
            .IsRequired()
            .HasColumnName("not_ready_for_donation");

        builder
            .Property(user => user.AbsenceBeginDate)
            .HasColumnName("absense_begin_date");

        builder
            .Property(user => user.AbsenceEndDate)
            .HasColumnName("absense_end_date");

        builder
            .Property(user => user.IsActive)
            .IsRequired()
            .HasColumnName("is_active");


    }
}