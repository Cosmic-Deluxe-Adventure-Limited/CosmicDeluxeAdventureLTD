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
         Name = "Internation Space Station",
         Description = "Originally built as a science and exploration space.  Since the growth of inter-planetary travel has become the premier gateway to other planets",
         
        });
      modelBuilder.Entity<Ship>().HasData(
        new Ship
        {
          ID = 1,
          Name = "Orbital Horizons",
          Description = "First and the finest of the Adventure Class Ships."
        });
      modelBuilder.Entity<Flight>().HasData(
        new Flight
        {
          ID = 1,
          Departure = DateTime.Parse("10/23/2022 07:56:00"),
          Arrival = DateTime.Parse("10/23/2022 23:10:00"),
          Status = (int)Status.OnTime,
          Miles=1000000
        },
      new Flight
      {
        ID = 2,
        Departure = DateTime.Parse("11/30/2023 10:10:00"),
        Arrival = DateTime.Parse("12/02/2023 14:00:00"),
        Status = (int)Status.Delayed,
        Miles = 2309847123
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
