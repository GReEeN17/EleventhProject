using EleventhProject.Server.Infrastructure.Entities.BloodType;
using EleventhProject.Server.Infrastructure.Entities.Breed;
using EleventhProject.Server.Infrastructure.Entities.City;
using EleventhProject.Server.Infrastructure.Entities.Clinic;
using EleventhProject.Server.Infrastructure.Entities.DonationHistory;
using EleventhProject.Server.Infrastructure.Entities.DonorSearchCard;
using EleventhProject.Server.Infrastructure.Entities.Pet;
using EleventhProject.Server.Infrastructure.Entities.PetVaccination;
using EleventhProject.Server.Infrastructure.Entities.User;
using EleventhProject.Server.Infrastructure.Entities.VaccinationDict;
using EleventhProject.Server.Infrastructure.Implementations.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EleventhProject.Server.Infrastructure.Implementations.DataContext;

public class DataContext : DbContext
{
    public DbSet<BloodTypeEntity> BloodTypeEntities { get; set; }
    public DbSet<BreedEntity> BreedEntities { get; set; }
    public DbSet<CityEntity> Cities { get; set; }
    public DbSet<ClinicEntity> Clinics { get; set; }
    public DbSet<DonationHistoryEntity> DonationHistories { get; set; }
    public DbSet<DonorSearchCardEntity> DonorSearchCards { get; set; }
    public DbSet<PetEntity> Pets { get; set; }
    public DbSet<PetVaccinationEntity> PetVaccinations { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<VaccinationDictEntity> VaccinationDicts { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region BloodType config

        modelBuilder.HasSequence<int>("blood_type_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"blood_type_sequence\"')");

        modelBuilder.ApplyConfiguration(new BloodTypeConfiguration());

        #endregion
        
        #region Breed config

        modelBuilder.HasSequence<int>("breed_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"breed_sequence\"')");

        modelBuilder.ApplyConfiguration(new BreedConfiguration());

        #endregion
        
        #region City config

        modelBuilder.HasSequence<int>("city_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"city_sequence\"')");

        modelBuilder.ApplyConfiguration(new CityConfiguration());

        #endregion

        #region Clinic config

        modelBuilder.HasSequence<int>("clinic_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"clinic_sequence\"')");

        modelBuilder.ApplyConfiguration(new ClinicConfiguration());

        #endregion

        #region DonationHistory config

        modelBuilder.HasSequence<int>("donation_history_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"donation_history_sequence\"')");

        modelBuilder.ApplyConfiguration(new DonationHistoryConfiguration());

        #endregion

        #region DonorSearch config

        modelBuilder.HasSequence<int>("donor_search_card_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"donor_search_card_sequence\"')");

        modelBuilder.ApplyConfiguration(new DonorSearchCardConfiguration());

        #endregion

        #region Pet config

        modelBuilder.HasSequence<int>("blood_type_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"pet_sequence\"')");

        modelBuilder.ApplyConfiguration(new PetConfiguration());

        #endregion

        #region PetType config

        modelBuilder.HasSequence<int>("pet_type_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"pet_type_sequence\"')");

        modelBuilder.ApplyConfiguration(new PetConfiguration());

        #endregion

        #region PetVaccination config

        modelBuilder.HasSequence<int>("pet_vaccination_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"pet_vaccination_sequence\"')");

        modelBuilder.ApplyConfiguration(new PetVaccinationConfiguration());

        #endregion

        #region User config

        modelBuilder.HasSequence<int>("user_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"user_sequence\"')");

        modelBuilder.ApplyConfiguration(new UserConfiguration());

        #endregion

        #region VaccinationDict config

        modelBuilder.HasSequence<int>("vaccination_dict_sequence")
            .StartsAt(1)
            .IncrementsBy(1)
            .HasMin(1)
            .HasMax(999999);

        modelBuilder.Entity<BloodTypeEntity>().Property(pm => pm.Id)
            .HasDefaultValueSql("nextval('\"vaccination_dict_sequence\"')");

        modelBuilder.ApplyConfiguration(new VaccinationDictConfiguration());

        #endregion


    }
    
    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }
    
    public DbSet<T> DbSet<T>() where T : class
    {
        return Set<T>();
    }

    public new IQueryable<T> Query<T>() where T : class
    {
        return Set<T>();
    }
}