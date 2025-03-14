using System.ComponentModel.DataAnnotations;

namespace MySqlApi.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        [Required]
        public string Pincode { get; set; } = string.Empty;

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Gender { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}