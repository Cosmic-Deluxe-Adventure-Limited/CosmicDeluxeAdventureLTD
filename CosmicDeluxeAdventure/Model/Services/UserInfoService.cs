using CosmicDeluxeAdventure.Data;
using CosmicDeluxeAdventure.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model.Services
{
  public class UserInfoService : IUserInfo
  {
    private IUserInfo userInfo;
    private CADDbContext _context;
    public UserInfoService(CADDbContext context)
    {
      _context = context;
    }
    public async Task<List<UserInfo>> GetAllUsers()
    {
      return await _context.UserInfo.ToListAsync();
    }
  }
}
