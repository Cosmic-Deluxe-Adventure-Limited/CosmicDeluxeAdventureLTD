using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model.Interfaces
{
  public interface IFlight
  {
    public Task<Flight> GetFlight(int id);
    public Task<List<Flight>> GetAllFlights();
    public Task<Flight> UpdateFlight(int flightId, Flight flight);
  }
}
