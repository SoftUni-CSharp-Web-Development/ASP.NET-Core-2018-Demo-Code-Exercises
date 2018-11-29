using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Services.Eventures.Web.Services.EventureEvents.Contracts;
using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using Sieve.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eventures.Api
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventuresEventsService eventsService;
        private readonly SieveProcessor sieveProcessor;

        public EventsController(
            IEventuresEventsService eventsService,
            SieveProcessor sieveProcessor)
        {
            this.eventsService = eventsService;
            this.sieveProcessor = sieveProcessor;
        }
        // GET: api/<controller>
        [HttpGet]
        public object Get(SieveModel sieve)
        {
            var events = this.eventsService
                .All();
            var filteredData = sieveProcessor.Apply(sieve, events);
            var toListedData = filteredData.ToList();
            return filteredData;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
