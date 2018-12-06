using Eventures.Models;

namespace Eventures.Services.Eventures.Web.Services.EveturesUsers.Contracts
{
    public interface IEventuresUsersService
    {
        EventuresUser GetByUsername(string username);
    }
}
