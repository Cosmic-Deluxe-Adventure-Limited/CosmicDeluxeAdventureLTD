using CosmicDeluxeAdventure.Data;
using CosmicDeluxeAdventure.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model.Services
{
  public class FlightService : IFlight
  {
    private IFlight flight;
    private CADDbContext _context;
    private enum Status { OnTime = 1, Delayed, Cancelled, Maintenence};

    public FlightService(CADDbContext context)
    {      
      _context = context;
    }

    public async Task<Flight> GetFlight(int id)
    {
      return await _context.Flight.FindAsync(id);
    }
    public async Task<List<Flight>> GetAllFlights()
    {
      return await _context.Flight
        .Include(l => l.Location)
        .Include( s => s.Ship)
        .ToListAsync();        
    }
    public async Task<Flight> UpdateFlight(int flightId, Flight flight)
    {
      _context.Entry(flight).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return flight;
    }
  }
}
