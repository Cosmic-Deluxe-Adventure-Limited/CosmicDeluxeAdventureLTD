using CosmicDeluxeAdventure.Model;
using CosmicDeluxeAdventure.Model.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class FlightController : ControllerBase
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IUserInfo _userInfo;
    private readonly IFlight _flight;
    public FlightController(ILogger<HomeController> logger, IUserInfo userinfo, IFlight flight)
    {
      _logger = logger;
      _userInfo = userinfo;
      _flight = flight;
    }
    [Route("getAllFlights")]
    [HttpGet]
    public async Task<IEnumerable<Flight>> Get()
    {
      Debug.WriteLine("GetData Hit");
      return await _flight.GetAllFlights();
    }
    [Route("getflight/{id}")]
    [HttpGet]
    public async Task<Flight> GetFlight(int id)
    {
      return await _flight.GetFlight(id);
    }
    [Route("updateFlight/{id}")]
    [HttpPut]
    public async Task<IActionResult> UpdateFlight(int id, Flight flight)
    {
      if(id != flight.ID)
      {
        return BadRequest();
      }
      var updatedFlight = await _flight.UpdateFlight(id, flight);
      return Ok(updatedFlight);
    }

  }
}
