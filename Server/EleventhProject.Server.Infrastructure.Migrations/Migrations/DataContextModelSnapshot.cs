﻿// <auto-generated />
using System;
using EleventhProject.Server.Infrastructure.Implementations.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EleventhProject.Server.Infrastructure.Migrations.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.HasSequence<int>("blood_type_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("breed_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("city_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("clinic_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("donation_history_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("donor_search_card_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("pet_type_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("pet_vaccination_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("user_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.HasSequence<int>("vaccination_dict_sequence")
                .HasMin(1L)
                .HasMax(999999L);

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.BloodType.BloodTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValueSql("nextval('\"vaccination_dict_sequence\"')");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("blood_type", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.Breed.BreedEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("breed", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.City.CityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("city", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.Clinic.ClinicEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("address");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("clinic", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.DonationHistory.DonationHistoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<int>("DonorId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<int>("RecipientId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DonorId");

                    b.HasIndex("RecipientId");

                    b.ToTable("donation_history", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.DonorSearchCard.DonorSearchCardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BloodAmount")
                        .HasColumnType("integer")
                        .HasColumnName("blood_amount");

                    b.Property<int>("ClinicId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("end_date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<bool>("IsUrgent")
                        .HasColumnType("boolean")
                        .HasColumnName("is_required");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)")
                        .HasColumnName("reason");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.HasIndex("CreatorId");

                    b.ToTable("donor_search_card", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.Pet.PetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<int>("BloodTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("BreedId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("name");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int>("PetTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("Weight")
                        .HasColumnType("integer")
                        .HasColumnName("weight");

                    b.HasKey("Id");

                    b.HasIndex("BloodTypeId");

                    b.HasIndex("BreedId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PetTypeId");

                    b.ToTable("pet", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.PetType.PetTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PetTypeEntity");
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.PetVaccination.PetVaccinationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<int>("PetId")
                        .HasColumnType("integer");

                    b.Property<int>("VaccinationDictId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("VaccinationDictId");

                    b.ToTable("pet_vaccination", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.User.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AbsenceBeginDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("absense_begin_date");

                    b.Property<DateTime?>("AbsenceEndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("absense_end_date");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("middle_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("name");

                    b.Property<bool>("NotReadyForDonation")
                        .HasColumnType("boolean")
                        .HasColumnName("not_ready_for_donation");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("password");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("phone_number");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("surname");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.VaccinationDict.VaccinationDictEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("vaccination_dict", (string)null);
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.Clinic.ClinicEntity", b =>
                {
                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.City.CityEntity", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.DonationHistory.DonationHistoryEntity", b =>
                {
                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.Pet.PetEntity", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.Pet.PetEntity", "Recipient")
                        .WithMany()
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donor");

                    b.Navigation("Recipient");
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.DonorSearchCard.DonorSearchCardEntity", b =>
                {
                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.Clinic.ClinicEntity", "Clinic")
                        .WithMany()
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.User.UserEntity", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.Pet.PetEntity", b =>
                {
                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.BloodType.BloodTypeEntity", "BloodType")
                        .WithMany()
                        .HasForeignKey("BloodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.Breed.BreedEntity", "Breed")
                        .WithMany()
                        .HasForeignKey("BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.User.UserEntity", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.PetType.PetTypeEntity", "PetType")
                        .WithMany()
                        .HasForeignKey("PetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BloodType");

                    b.Navigation("Breed");

                    b.Navigation("Owner");

                    b.Navigation("PetType");
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.PetVaccination.PetVaccinationEntity", b =>
                {
                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.Pet.PetEntity", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.VaccinationDict.VaccinationDictEntity", "VaccinationDict")
                        .WithMany()
                        .HasForeignKey("VaccinationDictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("VaccinationDict");
                });

            modelBuilder.Entity("EleventhProject.Server.Infrastructure.Entities.User.UserEntity", b =>
                {
                    b.HasOne("EleventhProject.Server.Infrastructure.Entities.City.CityEntity", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
