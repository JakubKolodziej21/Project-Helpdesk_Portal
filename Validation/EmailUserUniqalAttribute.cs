using System.ComponentModel.DataAnnotations;
using System;
using Project_Helpdesk_Portal.Data;

namespace Project_Helpdesk_Portal.Validation
{
    public class EmailUserUniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object value, ValidationContext validationContext)
        {
            var _context = (HelpdeskDbContext)validationContext.GetService(typeof(HelpdeskDbContext));
            var entity = _context.Users.SingleOrDefault(e => e.Email == value.ToString());

            if (entity != null)
            {
                return new ValidationResult(GetErrorMessage(value.ToString()));
            }
            return ValidationResult.Success;
        }

        public string GetErrorMessage(string email)
        {
            return $"Email {email} is already in use.";
        }
    }

    public class UsernameUserUniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object value, ValidationContext validationContext)
        {
            var _context = (HelpdeskDbContext)validationContext.GetService(typeof(HelpdeskDbContext));
            var entity = _context.Users.SingleOrDefault(e => e.Username == value.ToString());

            if (entity != null)
            {
                return new ValidationResult(GetErrorMessage(value.ToString()));
            }
            return ValidationResult.Success;
        }
        public string GetErrorMessage(string username)
        {
            return $"Nazwa {username} jest zajęta.";
        }
    }
}
