using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class Order
    {
        public EventuresUser User { get; set; }

        public string UserId { get; set; }

        public EventureEvent Event { get; set; }

        public int EventId { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
