using FMDC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Data
{
    public class FdmcDbContext : IdentityDbContext<FdmcUser>
    {

        public FdmcDbContext(DbContextOptions<FdmcDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
