using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Models
{
    public class EventuresUser: IdentityUser
    {
        public EventuresUser()
        {
            this.Orders = new HashSet<Order>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UniqueCitizenNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
