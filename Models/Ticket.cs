using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_Helpdesk_Portal.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public DateTime Created { get; set; }

        //[Required]
        public int DeviceId { get; set; }

        //[Required]
        public int StatusId { get; set; }

        //[Required]
        public int UserId { get; set; }

        [ForeignKey("DeviceId")]
        public Device Device { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
