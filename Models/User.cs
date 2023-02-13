using Microsoft.EntityFrameworkCore;
using Project_Helpdesk_Portal.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Project_Helpdesk_Portal.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required, EmailAddress]
        [EmailUserUnique]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [MaxLength(20)]
        [UsernameUserUniqueAttribute]
        public string Username { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        [Required]
        public bool IsHelpdeskStaff { get; set; }
    }
}
