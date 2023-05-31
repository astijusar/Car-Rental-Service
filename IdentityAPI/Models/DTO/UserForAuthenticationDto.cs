using System.ComponentModel.DataAnnotations;

namespace IdentityAPI.Models.DTO
{
    public class UserForAuthenticationDto
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
    }
}
