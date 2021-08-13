using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosmicDeluxeAdventure.Model.Interfaces
{
  public interface IUserInfo
  {
    public Task<List<UserInfo>> GetAllUsers();
  }
}
