using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Project_Helpdesk_Portal.Views.Home
{
    public class IndexModel : PageModel
    {
        public List<TicketInfo> ticketInfos = new List<TicketInfo>(); 
        public void OnGet()
        {
            try
            {
                String connectionString = "Server=(localdb)\\mssqllocaldb;Database=HelpdeskDb;Trusted_Connection=True";

                using (SqlConnection connection= new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "Select * from tickets";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TicketInfo ticketInfo = new TicketInfo();
                                ticketInfo.id = "" + reader.GetInt32(0);
                                ticketInfo.title = reader.GetString(1);
                                ticketInfo.description = reader.GetString(2);
                                ticketInfo.created = reader.GetDateTime(3).ToString();
                                ticketInfo.status = reader.GetString(4);
                                ticketInfo.user = reader.GetString(5);

                               ticketInfos.Add(ticketInfo);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

               Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }

    public class TicketInfo
    {
        public string id;
        public string title;
        public string description;
        public string created;
        public string device;
        public string status;
        public string user;

    }
}
