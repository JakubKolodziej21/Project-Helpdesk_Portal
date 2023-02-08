using System.ComponentModel.DataAnnotations;

namespace Project_Helpdesk_Portal.Entities
{
    public class Device
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        [MaxLength(30)]
        public string Location { get; set; }

        [Required]
        public bool IsMobile { get; set; }

        [Required]
        public bool IsArchive { get; set; }
    }
}
