using Microsoft.AspNetCore.Identity;

namespace FMDC.Models
{
    public class FdmcUser : IdentityUser
    {
        public string Nickname { get; set; }
    }
}
