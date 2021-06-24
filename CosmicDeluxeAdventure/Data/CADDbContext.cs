using CosmicDeluxeAdventure.Model;
using Microsoft.EntityFrameworkCore;

namespace CosmicDeluxeAdventure.Data
{
  public class CADDbContext : DbContext
  {
    public DbSet<UserInfo> UserInfo { get; set; }
    public CADDbContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
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
