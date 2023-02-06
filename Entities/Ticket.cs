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

        //Database Keys
        public virtual Device Devices { get; set; }

        public virtual Status Statuss { get; set; }
        public virtual User Users{ get; set; }

         }
}
