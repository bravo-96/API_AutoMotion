using SMS.Talent.BE.Models.Dto;

namespace SMS.Talent.BE.Authorization.Interfaces
{
    public interface ITokenService
    {
        LoginResponseDTO GenerateJwtToken(LoginResponseDTO response);
    }
}
