using System;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Models
{
    public class EventuresUser: IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UniqueCitizenNumber { get; set; }
    }
}
