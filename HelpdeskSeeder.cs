//using Microsoft.AspNetCore.Authentication;
//using Project_Helpdesk_Portal.Entities;

//namespace Project_Helpdesk_Portal
//{
//    public class HelpdeskSeeder
//    {
//        private readonly HelpdeskDbContext _dbContext;
//        public HelpdeskSeeder(HelpdeskDbContext dbContext) 
//        {
//            _dbContext = dbContext;
//        }

//        public void Seed()
//        {
//            if (_dbContext.Database.CanConnect())
//            {
//                if (!_dbContext.Tickets.Any())
//                {
//                    var tickets = GetTickets();
//                    _dbContext.Tickets.AddRange(tickets);
//                }
//            }
//        }

//        private IEnumerable<Ticket> GetTickets()
//        {
//            var tickets= new List<Ticket>()
//            {
//                new Ticket()
//                {
//                    Title = "Przygotowywanie Stanowiska - Adam Nowak",
//                    Description ="Bardzo proszę o sprawdzenie stanowiska w dziale HR, czy wszystko działa oraz czy są zaintalowane programy: Office 365, 7zip, Chrome",
//                    Created

//                }
//            }
//        }
//    }
//}
