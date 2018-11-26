using System;

namespace Eventures.Models
{
    public class EventureEvent
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TotalTickets { get; set; }

        public decimal TicketPrice { get; set; }
    }
}
