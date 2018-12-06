using System.Linq;
using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EveturesUsers.Contracts;

namespace Eventures.Services.Eventures.Web.Services.EveturesUsers
{
    public class EventuresUsersService : Contracts.IEventuresUsersService
    {
        private EventuresDbContext context;

        public EventuresUsersService(EventuresDbContext context)
        {
            this.context = context;
        }

        public EventuresUser GetByUsername(string username)
            => this.context.Users.FirstOrDefault(u => u.UserName == username);
    }
}
