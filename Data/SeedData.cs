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
                },
                new Ticket
                {
                    Title = "Przygotowywanie stanowiska",
                    Description = "Bardzo proszę o aktualizację i sprawdzenie myszki.",
                    Created = DateTime.Parse("2023-02-04 07:01:12"),
                    Device = new Device()
                    {
                        Name = "WSEI-LA-12",
                        Description = "PC DELL workstation 360VZ",
                        Location = "Los_Angeles",
                        IsMobile = false,
                        IsArchive = false
                    },

                    Status = new Status()
                    {
                        Name = "Open",
                        Logo = "Yellow"
                    },

                    User = new User()
                    {
                        Name = "Jakub Kołodziej",
                        Email = "jakub.kolodziej28@microsoft.wsei.edu.pl",
                        Password = "12345678",
                        Username = "jkolodziej",
                        IsAdmin = false,
                        IsHelpdeskStaff = true
                    }
                },

                new Ticket
                {
                    Title = "Odejście pracownika",
                    Description = "Marek Markowski - Proszę o wykonanie procedury oraz usunięcie dostępów do projektu Yellow_Submarine",
                    Created = DateTime.Parse("2022-12-22 22:17:59"),
                    Device = new Device()
                    {
                        Name = "WSEI-SRV-02",
                        Description = "DELL SERVER Active Directory",
                        Location = "Server_room",
                        IsMobile = false,
                        IsArchive = false
                    },
                    Status = new Status()
                    {
                        Name = "Cloused",
                        Logo = "Blue"
                    },
                    User = new User()
                    {
                        Name = "Administrator",
                        Email = "root@admin.pl",
                        Password = "12341234",
                        Username = "root",
                        IsAdmin = true,
                        IsHelpdeskStaff = true
                    }
                }
                
                );

                
                context.SaveChanges();

                
            }
        }



    }
}
