using System.Linq;
using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresOrders.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Services.Eventures.Web.Services.EventuresOrders
{
    public class EventuresOrdersService : IEventuresOrdersService
    {
        private readonly EventuresDbContext context;

        public EventuresOrdersService(EventuresDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Order> AllWithEvents()
            => this.context.Orders.Include(o => o.Event);
    }
}
