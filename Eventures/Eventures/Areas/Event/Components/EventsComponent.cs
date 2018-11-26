using System.Collections.Generic;
using System.Threading.Tasks;
using Eventures.Areas.Event.ViewModels;
using Eventures.Services.Eventures.Web.Services.EventureEvents.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Areas.Event.Components
{
    public class EventsComponent : ViewComponent
    { 
        private readonly IEventuresEventsService eventsService;

        public EventsComponent(IEventuresEventsService eventsService)
        {
            this.eventsService = eventsService;
        }

        public IViewComponentResult Invoke()
        {
            var events = this.eventsService
                .All();
            var viewModels = new List<EventureEventViewModel>();

            foreach (var eventureEvent in events)
            {
                var eventViewModel = new EventureEventViewModel
                {
                    End = eventureEvent.End,
                    Start = eventureEvent.Start,
                    Name = eventureEvent.Name,
                    Place = eventureEvent.Place,
                    TicketPrice = eventureEvent.TicketPrice,
                    TotalTickets = eventureEvent.TotalTickets
                };
                viewModels.Add(eventViewModel);
            }

            return this.View(viewModels);
        }
    }
}
