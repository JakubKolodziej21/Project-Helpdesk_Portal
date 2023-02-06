namespace Project_Helpdesk_Portal.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int DeviceId { get; set; }

        public int StatusId { get; set; }

        public int UserId { get; set; }

        public virtual User Users { get; set; }
    }
}
