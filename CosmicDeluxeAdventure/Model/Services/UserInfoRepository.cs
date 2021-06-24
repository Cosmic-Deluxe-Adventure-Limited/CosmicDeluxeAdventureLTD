using CosmicDeluxeAdventure.Data;
using CosmicDeluxeAdventure.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model.Services
{
  public class UserInfoRepository : IUserInfo
  {
    private IUserInfo userInfo;
    private CADDbContext _context;
    public UserInfoRepository(CADDbContext context)
    {
      _context = context;
    }
    public async Task<List<UserInfo>> GetAllUsers()
    {
      return await _context.UserInfo.ToListAsync();
    }
  }
}
