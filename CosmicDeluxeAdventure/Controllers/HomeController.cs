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
  [Route("api/home")]
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
  }
}
