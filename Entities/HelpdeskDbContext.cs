using Microsoft.EntityFrameworkCore;

namespace Project_Helpdesk_Portal.Entities
{
    public class HelpdeskDbContext : DbContext
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=HelpdeskDb;Trusted_Connection=True";
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Status> Statuss { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                 .Property(t => t.Id)
                 .IsRequired();

           modelBuilder.Entity<Status>()
                .Property(s => s.Id)
                .IsRequired();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
