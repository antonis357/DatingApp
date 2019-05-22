using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 8, ErrorMessage = "Minimum password length must be 8")]
        public string Password { get; set; }
    }
}