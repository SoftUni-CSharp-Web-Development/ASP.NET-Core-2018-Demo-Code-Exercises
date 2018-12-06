using System.Linq;
using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventureEvents.Contracts;

namespace Eventures.Services.Eventures.Web.Services.EventureEvents
{
    public class EventuresEventsService : IEventuresEventsService
    {
        private readonly EventuresDbContext context;

        public EventuresEventsService(EventuresDbContext context)
        {
            this.context = context;
        }

        public IQueryable<EventureEvent> All() => this.context.EventureEvents;

        public IQueryable<EventureEvent> AllOrderedByTicketPrice()
            => this.All()
                .OrderBy(ee => ee.TicketPrice);
    }
}
