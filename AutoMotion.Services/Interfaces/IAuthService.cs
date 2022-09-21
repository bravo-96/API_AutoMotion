using Automoviles.Models.DTO;
using System.Threading.Tasks;

namespace AutoMotion.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> Login(LoginRequestDTO model);
        //Task<LoginResponseDTO> ActiveDirectoryAuthenticate(LoginRequestDTO model);
    }
}
