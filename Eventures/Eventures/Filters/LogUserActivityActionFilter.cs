using System;
using System.Linq;
using Eventures.Services.Eventures.Web.Services.EventureEvents;
using Eventures.Services.Eventures.Web.Services.EventureEvents.Contracts;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Eventures.Filters
{
    public class LogUserActivityActionFilter: ActionFilterAttribute
    {
        private readonly IEventuresEventsService eventsService;
        private readonly ILogger<LogUserActivityActionFilter> logger;

        public LogUserActivityActionFilter(
            IEventuresEventsService eventsService, ILogger<LogUserActivityActionFilter> logger)
        {
            this.eventsService = eventsService;
            this.logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userName = context.HttpContext.User.Identity.Name;
            var eventureEvent = this.eventsService.All().FirstOrDefault();
            var eventName = eventureEvent.Name;
            var eventStart = eventureEvent.Start;
            var eventEnd = eventureEvent.End;
            var logMessage = $"[{DateTime.Now}] User {userName} viewed event {eventName} ( {eventStart} / {eventEnd} )";
            logger.LogInformation(logMessage);

            base.OnActionExecuting(context);
        }
    }
}
