using System;
using System.Collections.Generic;
using System.Text;
using Eventures.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Data
{
    public class EventuresDbContext : IdentityDbContext<EventuresUser>
    {
        public EventuresDbContext(DbContextOptions<EventuresDbContext> options)
            : base(options)
        {
        }

        //public EventuresDbContext()
        //    : base(new DbContextOptionsBuilder<EventuresDbContext>().O)
        //{
         
        //}

        public DbSet<EventureEvent> EventureEvents { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<CustomLog> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasKey(o => new {o.UserId, o.EventId});
            base.OnModelCreating(builder);
        }
    }
}
