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
    public HomeController(ILogger<HomeController> logger, IUserInfo userinfo)
    {
      _logger = logger;
      _userInfo = userinfo;
    }
    [Route("{controller}/GetData")]
    [HttpGet]
    public async Task<IEnumerable<UserInfo>> Get()
    {
      Debug.WriteLine("GetData Hit");
      return await _userInfo.GetAllUsers();
    }
  }
}
