using Microsoft.EntityFrameworkCore;
using TravelAgency.DataAccess.Entities;

namespace TravelAgency.DataAccess;
public class TravelAgencyDbContext : DbContext
{            
    public TravelAgencyDbContext(DbContextOptions<TravelAgencyDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);
        modelBuilder.Entity<RoleEntity>().HasKey(r => r.Id);
        modelBuilder.Entity<UserEntity>()
            .HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleId);
        
        modelBuilder.Entity<ClientEntity>().HasKey(cl => cl.Id);
        modelBuilder.Entity<ClientEntity>()
            .HasOne(cl => cl.User)
            .WithMany(u => u.Clients)
            .HasForeignKey(cl => cl.UserId);
        
        modelBuilder.Entity<EmployeeEntity>().HasKey(e => e.Id);
        modelBuilder.Entity<EmployeeEntity>()
            .HasOne(e => e.User)
            .WithMany(u => u.Employees)
            .HasForeignKey(e => e.UserId);
        
        modelBuilder.Entity<CountryEntity>().HasKey(c => c.Id);
        modelBuilder.Entity<CountryEntity>()
            .HasMany(c => c.Regions)
            .WithOne(r => r.Country)
            .HasForeignKey(r => r.CountryId);

        modelBuilder.Entity<RegionEntity>().HasKey(r => r.Id);
        modelBuilder.Entity<RegionEntity>()
            .HasMany(r => r.Cities)
            .WithOne(c => c.Region)
            .HasForeignKey(c => c.RegionId);

        modelBuilder.Entity<CityEntity>().HasKey(c => c.Id);

        modelBuilder.Entity<PostEntity>().HasKey(p => p.Id);
        modelBuilder.Entity<PostEntity>()
            .HasMany(p => p.EmployeePosts)
            .WithOne(ep => ep.Post)
            .HasForeignKey(ep => ep.PostId);

        modelBuilder.Entity<EmployeePostEntity>().HasKey(ep => ep.Id);
        modelBuilder.Entity<EmployeePostEntity>()
            .HasOne(ep => ep.Employee)
            .WithMany(e => e.EmployeePosts)
            .HasForeignKey(ep => ep.EmployeeId);

        modelBuilder.Entity<TourTypeEntity>().HasKey(tt => tt.Id);
        modelBuilder.Entity<TourTypeEntity>()
            .HasMany(tt => tt.Tours) 
            .WithOne(t => t.TourType)
            .HasForeignKey(t => t.TourTypeId);

        modelBuilder.Entity<TourEntity>().HasKey(t => t.Id);
        modelBuilder.Entity<TourEntity>()
            .HasOne(t => t.TourType)
            .WithMany(tt => tt.Tours)
            .HasForeignKey(t => t.TourTypeId);

        modelBuilder.Entity<PurchaseTourEntity>().HasKey(pt => pt.Id);
        modelBuilder.Entity<PurchaseTourEntity>()
            .HasOne(pt => pt.Employee)
            .WithMany() 
            .HasForeignKey(pt => pt.EmployeeId);
        modelBuilder.Entity<PurchaseTourEntity>()
            .HasOne(pt => pt.Client)
            .WithMany() 
            .HasForeignKey(pt => pt.ClientId);
        modelBuilder.Entity<PurchaseTourEntity>()
            .HasOne(pt => pt.Tour)
            .WithMany(t => t.PurchaseTours)
            .HasForeignKey(pt => pt.TourId);

    }
}