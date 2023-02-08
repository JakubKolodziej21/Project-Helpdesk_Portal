using System.ComponentModel.DataAnnotations;

namespace Project_Helpdesk_Portal.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        [Required]
        public bool IsHelpdeskStaff { get; set; }
    }
}
