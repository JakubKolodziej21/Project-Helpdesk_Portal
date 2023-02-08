using System.ComponentModel.DataAnnotations;

namespace Project_Helpdesk_Portal.Entities
{
    public class Status
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }
    }
}
