using Microsoft.EntityFrameworkCore;
using Project_Helpdesk_Portal.Models;
using System;
using System.Collections.Generic;

namespace Project_Helpdesk_Portal.Data
{
    public class HelpdeskDbContext : DbContext
    {
        public HelpdeskDbContext(DbContextOptions<HelpdeskDbContext> options) : base(options) { }
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=HelpdeskDb;Trusted_Connection=True";
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Status> Statuss { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
