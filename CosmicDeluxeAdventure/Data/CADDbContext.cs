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
    private enum Status { OnTime = 1, Delayed, Cancelled, Maintenence };
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
         Name = "International Space Station",
         Description = "Originally built as a science and exploration space.  Since the growth of inter-planetary travel has become the premier gateway to other planets",
         
        },
         new Location
         {
           ID = 2,
           Name = "Moon",
           Description = "It's our first and largest satellite, tidally locked for a perfect view of earth"
         },
         new Location
         {
           ID = 3,
           Name = "Mars",
           Description = "It's red, and windy.  Perfect for that wonder desert getaway!"
         }
        );

      modelBuilder.Entity<Ship>().HasData(
        new Ship
        {
          ID = 1,
          Name = "Orbital Horizons",
          Description = "First and the finest of the Adventure Class Ships."
        },
        new Ship
        {
          ID = 2,
          Name = "Terminal Velocity",
          Description = "Second Adventure Class Ship with bigger boosters."
        },
        new Ship
        {
          ID = 3,
          Name = "Lunar Bliss",
          Description ="Third Adventure Class Ship to get you to the moon in luxury"
        }
        );
      modelBuilder.Entity<Flight>().HasData(
        new Flight
        {
          ID = 1,
          Departure = DateTime.Parse("10/23/2022 07:56:00"),
          Arrival = DateTime.Parse("10/23/2022 23:10:00"),
          Status = (int)Status.OnTime,
          Miles=1000000,
          ShipId = 3,
          LocationId = 2
        },
      new Flight
      {
        ID = 2,
        Departure = DateTime.Parse("11/30/2023 10:10:00"),
        Arrival = DateTime.Parse("12/02/2023 14:00:00"),
        Status = (int)Status.Delayed,
        Miles = 2309847123,
        ShipId = 2,
        LocationId = 1
      },
      new Flight
      {
        ID = 3,
        Departure = DateTime.Parse("1/10/2024 10:10:00"),
        Arrival = DateTime.Parse("2/22/2024 16:00:00"),
        Status = (int)Status.Delayed,
        Miles = 2309847123,
        ShipId = 1,
        LocationId = 3

      }
      );
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
        },
        new UserInfo{
          ID = 2,
          FirstName = "Samus",
          LastName = "Aran",
          Address = "SR388",
          City = "Ancient City",
          State = "Unknown",
          ZipCode = 00000,
          Country = "Zebes",
          PhoneNumber = 1234567890,
          UserName = "lastMet2"
        });
    }
  }
}
