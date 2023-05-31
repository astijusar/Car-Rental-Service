using System.ComponentModel.DataAnnotations;

namespace IdentityAPI.Models.DTO
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = null!;


        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = null!;


        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Password is required")]
        public string Passowrd { get; set; } = null!;
    }
}
