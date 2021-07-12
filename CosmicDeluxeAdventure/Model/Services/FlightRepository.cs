using CosmicDeluxeAdventure.Data;
using CosmicDeluxeAdventure.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model.Services
{
  public class FlightRepository : IFlight
  {
    private IFlight flight;
    private CADDbContext _context;
    private enum Status { OnTime = 1, Delayed, Cancelled, Maintenence};

    public FlightRepository(CADDbContext context)
    {      
      _context = context;
    }

    public async Task<Flight> GetFlight(int id)
    {
      return await _context.Flight.FindAsync(id);
    }
    public async Task<Flight> GetFirstFlight()
    {
      return await _context.Flight.FirstOrDefaultAsync();
    }
  }
}
