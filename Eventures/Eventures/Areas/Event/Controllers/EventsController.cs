using System.Collections.Generic;
using System.Linq;
using AutoMapper;

using Eventures.Areas.Event.ViewModels;
using Eventures.Filters;
using Eventures.Services.Eventures.Web.Services.EventureEvents.Contracts;

using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using X.PagedList;

namespace Eventures.Areas.Event.Controllers
{
    // [Authorize]  
    [Area("Event")]
    public class EventsController : Controller
    {
        private readonly IEventuresEventsService eventsService;
        private readonly IMapper mapper;

        public EventsController(
            IEventuresEventsService eventsService,
            IMapper mapper)
        {
            this.eventsService = eventsService;
            this.mapper = mapper;
        }

        [ServiceFilter(typeof(LogUserActivityActionFilter))]
        public IActionResult Index(int? page)
        {
            var events = this.eventsService.AllOrderedByTicketPrice();
            var viewModels = new List<EventureEventViewModel>();

            foreach (var eventureEvent in events)
            {
                var eventViewModel = this.mapper.Map<EventureEventViewModel>(eventureEvent);
                viewModels.Add(eventViewModel);
            }

            var nextPage = page ?? 1;
            var pagedViewModels = viewModels.ToPagedList(nextPage, 3);

            return this.View(pagedViewModels);
        }
    }
}