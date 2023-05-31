using IdentityAPI.Models.DTO;

namespace IdentityAPI.Services
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
