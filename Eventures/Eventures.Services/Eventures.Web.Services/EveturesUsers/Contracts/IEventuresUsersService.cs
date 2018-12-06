using Eventures.Models;

namespace Eventures.Services.Eventures.Web.Services.EveturesUsers.Contracts
{
    public interface IUsersService
    {
        EventuresUser GetByUsername(string username);
    }
}
