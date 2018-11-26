using System;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data;
using Eventures.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;


namespace Eventures.Middlewares
{
    public class SeedDataMiddleware
    {
        private readonly RequestDelegate next;

        public SeedDataMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(
            HttpContext context,
            EventuresDbContext dbContext,
            UserManager<EventuresUser> usermanager,
            RoleManager<IdentityRole> roleManager)
        {
            if (!dbContext.EventureEvents.Any())
            {
                this.SeedEvents(dbContext);
            }

            if (!dbContext.Roles.Any())
            {
                await this.SeedRoles(usermanager, roleManager);
            }

            await this.next(context);
        }

        private async Task SeedRoles(
            UserManager<EventuresUser> usermanager,
            RoleManager<IdentityRole> roleManager)
        {
            var result = await roleManager.CreateAsync(new IdentityRole("Administrator"));
            if (result.Succeeded && usermanager.Users.Any())
            {
                var firstUser = usermanager.Users.FirstOrDefault();
                await usermanager.AddToRoleAsync(firstUser, "Administrator");
            }

        }

        private void SeedEvents(EventuresDbContext dbContext)
        {
            for (int i = 1; i <= 10; i++)
            {
                var sampleEvent = new EventureEvent()
                {
                    Name = $"Sample event number {i}",
                    Place = $"Sample place address 100{i}",
                    Start = DateTime.Now.Add(TimeSpan.FromDays(i)),
                    End = DateTime.Now.Add(TimeSpan.FromDays(i * 2)),
                    TicketPrice = 10 + i,
                    TotalTickets = i * 100
                };
                dbContext.EventureEvents.Add(sampleEvent);
            }
            dbContext.SaveChanges();
        }
    }
}
