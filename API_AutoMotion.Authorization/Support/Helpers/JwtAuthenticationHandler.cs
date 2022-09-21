using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SMS.Talent.BE.Authorization.Support.Helpers
{
    public class JwtAuthenticationOptions : AuthenticationSchemeOptions
    {
    }

    public class JwtAuthenticationHandler : AuthenticationHandler<JwtAuthenticationOptions>
    {

        public const string SchemeName = "TokenAuth";

        public JwtAuthenticationHandler(
            IOptionsMonitor<JwtAuthenticationOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock
            ) : base(options, logger, encoder, clock)
        {
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            string auth;
            var claims = Context.User;
            auth = Context.Request.Headers["Authorization"];
            if (auth == null)
            {
                return AuthenticateResult.Fail("No fue enviado el JWT token");
            }
            var auths = auth.Split(" ");
            if (auths[0].ToLower() != "bearer") return AuthenticateResult.Fail("Token invalido");

            return AuthenticateResult.Success(new AuthenticationTicket(claims, SchemeName));

        }
        protected override async Task HandleChallengeAsync(AuthenticationProperties properties)
        {

            await base.HandleChallengeAsync(properties);
            Response.StatusCode = 401;
            string output = "Acceso no autorizado";
            await Response.BodyWriter.WriteAsync(Encoding.UTF8.GetBytes(output));
        }
    }
}
