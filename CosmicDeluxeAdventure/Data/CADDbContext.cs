using CosmicDeluxeAdventure.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace CosmicDeluxeAdventure.Data
{
  public class CADDbContext : DbContext
  {
    public DbSet<UserInfo> UserInfo { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<Ship> Ship { get; set; }
    public DbSet<Flight> Flight { get; set; }
    public CADDbContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Location>().HasData(
        new Location
        {
         ID = 1,
         Name = "Internation Space Station",
         Description = "Originally built as a science and exploration space.  Since the growth of inter-planetary travel has become the premier gateway to other planets"         
        });
      modelBuilder.Entity<Ship>().HasData(
        new Ship
        {
          ID = 1,
          Name = "Orbital Endeavor"
        });
      modelBuilder.Entity<Flight>().HasData(
        new Flight
        {
          ID = 1,
          Departure = DateTime.Parse("10/23/2022 07:56:00"),
          Arrival = DateTime.Parse("10/23/2022 23:10:00")
        });
      modelBuilder.Entity<UserInfo>().HasData(
        new UserInfo
        {
          ID = 1,
          FirstName = "Fox",
          LastName = "McCloud",
          Address = "1234 Corneria Way",
          City = "Imperial Base",
          State = "Alpha",
          ZipCode = 12345,
          Country = "Corneria",
          PhoneNumber = 1112223333,
          UserName = "barrelRoll1"
        });
    }
  }
}
