using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_Helpdesk_Portal.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public int DeviceId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("DeviceId")]
        public Devices Device { get; set; }

        [ForeignKey("StatusId")]
        public Statuss Status { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }
    }
}
