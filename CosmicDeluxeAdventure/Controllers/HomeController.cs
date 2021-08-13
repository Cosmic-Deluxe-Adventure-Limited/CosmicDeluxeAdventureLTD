using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmicDeluxeAdventure.Model.Services;
using CosmicDeluxeAdventure.Model.Interfaces;
using CosmicDeluxeAdventure.Model;
using System.Diagnostics;

namespace CosmicDeluxeAdventure.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase //Inherit from Controller supports views.  ControllerBase does not support views
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IUserInfo _userInfo;
    private readonly IFlight _flight;
    public HomeController(ILogger<HomeController> logger, IUserInfo userinfo, IFlight flight)
    {
      _logger = logger;
      _userInfo = userinfo;
      _flight = flight;
    }
    [Route("{controller}/server/GetAllUsers")]
    [HttpGet]
    public async Task<IEnumerable<UserInfo>> Get()
    {
      Debug.WriteLine("GetData Hit");
      return await _userInfo.GetAllUsers();
    }
    [Route("{controller}/flights/getflight/{id}")]
    [HttpGet]
    public async Task<Flight> GetFlight(int id)
    {
      //let flightData = {
      //    arrival: "2022-10-23T23:10:00",
      //    departure: "2022-10-23T07:56:00",
      //    id: 1,
      //    location: null,
      //    miles: 0,
      //    shipId: null,
      //    status: 1
      //};
      return await _flight.GetFlight(id);
    }
  }
}
