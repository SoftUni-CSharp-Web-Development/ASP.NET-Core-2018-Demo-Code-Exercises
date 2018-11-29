using System;
using System.Collections;
using System.Collections.Generic;
using Sieve.Attributes;

namespace Eventures.Models
{
    public class EventureEvent
    {
        public EventureEvent()
        {
            this.Orders = new HashSet<Order>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TotalTickets { get; set; }

        [Sieve(CanFilter = true, CanSort = true, Name="price")]
        public decimal TicketPrice { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
