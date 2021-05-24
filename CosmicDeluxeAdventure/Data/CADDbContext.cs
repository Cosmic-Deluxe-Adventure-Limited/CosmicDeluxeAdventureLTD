using CosmicDeluxeAdventure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Data
{
  public class CADDbContext : DbContext
  {
    public DbSet<UserInfo> TABLENAME { get; set; }
    public CADDbContext(DbContextOptions<CADDbContext> options) : base(options)
    {

    }
  }
}
