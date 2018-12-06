using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventureEvents;
using Eventures.Services.Eventures.Web.Services.EventureEvents.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Xunit;

namespace Eventures.Services.Tests.Eventures.Web.Services.Tests.EventureEvents
{
    public class EventureEventsServiceTests
    {
        private readonly EventuresDbContext context;
        private readonly IEventuresEventsService service;
        private readonly IServiceProvider provider;

        public EventureEventsServiceTests()
        {
            var services = new ServiceCollection();
            services.AddDbContext<EventuresDbContext>(opt =>
                opt.UseInMemoryDatabase(Guid.NewGuid().ToString()));
            services.AddScoped<IEventuresEventsService, EventuresEventsService>();

            this.provider = services.BuildServiceProvider();
            this.context = provider.GetService<EventuresDbContext>();
            this.service = provider.GetService<IEventuresEventsService>();
        }

        [Fact]
        public void All_WithExistingsData_ShouldReturnAllOfExistingData()
        {        
            var eventModel = new EventureEvent();
            context.EventureEvents.Add(eventModel);
            context.SaveChanges();

            var result = service.All().ToList();

            // expect data
            result.ShouldNotBeEmpty();

            var entity = result[0];

            entity.ShouldBeSameAs(eventModel);
        }

        [Fact]
        public void All_WithNoExistingsData_ShouldReturnEmptyCollection()
        {
            Thread.Sleep(1000);
            var result = service.All().ToList();

            result.ShouldBeEmpty();
        }

        [Fact]
        public void AllOrderedByTicketPrice_WithSortedByTicketPriceCollection_ShouldReturnSameCollection()
        {
            var eventsOrderedByTickets = new List<EventureEvent>
            {
                new EventureEvent {TicketPrice = 1},
                new EventureEvent {TicketPrice = 2},
                new EventureEvent {TicketPrice = 3}
            };

            this.context.AddRange(eventsOrderedByTickets);
            this.context.SaveChanges();

            var result = this.service.AllOrderedByTicketPrice().ToList();

            result.ShouldBe(eventsOrderedByTickets);
        }

        [Fact]
        public void AllOrderedByTicketPrice_WithUnsortedEventsCollection_ShouldReturnSortedCollection()
        {
            var unorderedEvents = new List<EventureEvent>
            {
                new EventureEvent {TicketPrice = 4},
                new EventureEvent {TicketPrice = 1},
                new EventureEvent {TicketPrice = 3}
            };

            this.context.AddRange(unorderedEvents);
            this.context.SaveChanges();

            var result = this.service.AllOrderedByTicketPrice().ToList();
            var sortedEntites = unorderedEvents.OrderBy(x => x.TicketPrice);

            result.ShouldBe(sortedEntites);
        }
    }
}
