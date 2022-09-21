using AutomovilesEs.Api.Authorization.Interfaces;

namespace AutomovilesEs.Api.Authorization.Implements
{
    public class TokenParameters : ITokenParameters
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Id { get; set; }
    }
}
