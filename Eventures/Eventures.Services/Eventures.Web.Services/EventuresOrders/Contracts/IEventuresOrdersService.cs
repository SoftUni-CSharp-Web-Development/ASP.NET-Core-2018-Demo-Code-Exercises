using System.Linq;
using Eventures.Models;

namespace Eventures.Services.Eventures.Web.Services.EventuresOrders.Contracts
{
    public interface IEventuresOrdersService
    {
        IQueryable<Order> AllWithEvents();
    }
}
