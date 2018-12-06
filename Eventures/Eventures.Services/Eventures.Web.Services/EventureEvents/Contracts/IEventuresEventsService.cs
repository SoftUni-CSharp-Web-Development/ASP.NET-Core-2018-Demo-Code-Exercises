using System.Linq;
using Eventures.Models;

namespace Eventures.Services.Eventures.Web.Services.EventureEvents.Contracts
{
    public interface IEventuresEventsService
    {
        IQueryable<EventureEvent> All();

        IQueryable<EventureEvent> AllOrderedByTicketPrice();
    }
}
