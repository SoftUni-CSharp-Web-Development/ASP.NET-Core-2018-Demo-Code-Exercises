using System.Collections.Generic;
using System.Linq;
using Eventures.Areas.Event.ViewModels;
using Eventures.Filters;
using Eventures.Services.Eventures.Web.Services.EventureEvents.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Areas.Event.Controllers
{
    [Authorize]  
    public class EventsController : Controller
    {
        private readonly IEventuresEventsService eventsService;

        public EventsController(IEventuresEventsService eventsService)
        {
            this.eventsService = eventsService;
        }

        [ServiceFilter(typeof(LogUserActivityActionFilter))]
        public IActionResult Index()
        {
           

            return View();
        }
    }
}