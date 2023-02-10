using Microsoft.EntityFrameworkCore;
using Project_Helpdesk_Portal.Models;
using System;

namespace Project_Helpdesk_Portal.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HelpdeskDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<HelpdeskDbContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Tickets.Any())
                {
                    return; // dane już zostały dodane do bazy danych
                }
                context.Tickets.AddRange(
                new Ticket
                {
                    Title = "Instalacja oprogramowania",
                    Description = "Bardzo proszę o instalację programu 7zip",
                    Created = DateTime.Parse("2023-01-22 10:35:59"),
                    Device = new Device()
                    {
                        Name = "WSEI-TOKIO-L09",
                        Description = "Laptop Lenovo Thinkpad",
                        Location = "Tokio",
                        IsMobile = true,
                        IsArchive = false
                    },
                    Status = new Status()
                    {
                        Name = "New",
                        Logo = "Green"
                    },
                    User = new User()
                    {
                        Name = "Alicja Kowal",
                        Email = "akowal@gmail.com",
                        Password = "12345678",
                        Username = "akowal",
                        IsAdmin = false,
                        IsHelpdeskStaff = false
                    }
                }
                );

                
                context.SaveChanges();

                
            }
        }



    }
}
