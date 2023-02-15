using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_Helpdesk_Portal.Models;
using System;
using System.Collections.Generic;

namespace Project_Helpdesk_Portal.Data
{
    public class HelpdeskDbContext : IdentityDbContext
    {
        public HelpdeskDbContext(DbContextOptions<HelpdeskDbContext> options) : base(options) { }
        
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Status> Statuss { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }


      
    }

}
