using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SMS.Talent.BE.Authorization.Interfaces;
using SMS.Talent.BE.Authorization.Support.Helpers;
using SMS.Talent.BE.Models.Dto;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SMS.Talent.BE.Authorization.Implements
{
    public class TokenService : ITokenService
    {
        private readonly JwtConfig _jwtConfig;

        public TokenService(
            IOptionsMonitor<JwtConfig> optionMonitor
            )
        {
            _jwtConfig = optionMonitor.CurrentValue;
        }

        /// <summary>
        /// Genera el JwtToken
        /// </summary>
        /// <param name="response">Respuesa del Login</param>
        /// <returns></returns>
        public LoginResponseDTO GenerateJwtToken(LoginResponseDTO response)
        {
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var claims = new List<Claim>
            {
                new Claim("Email", response.Email),
                new Claim(ClaimTypes.NameIdentifier, response.NombreCompleto),
                new Claim(ClaimTypes.Name, response.NombreCompleto),
                new Claim("UserName", response.UserName),
                new Claim(JwtRegisteredClaimNames.Sub, response.NombreCompleto),
                new Claim(JwtRegisteredClaimNames.Email, response.Email),
            };
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            response.Token = jwtToken;
            return response;
        }
    }
}
