using AutoMotion.Authorization.Interfaces;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace AutoMotion.API.Controllers
{
    public class AuthController : Controller
    {
        #region Dependencias
        private readonly IAuthService _authService;
        private readonly ITokenService _tokenService;
        #endregion

        #region Constructor
        public AuthController(
            IAuthService authService, ITokenService tokenService )
        {
            _authService = authService;
            _tokenService = tokenService;
        }
        #endregion

        #region EndPoints

        [AllowAnonymous]
        [SwaggerOperation(Summary = "Login")]
        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginResponseDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById( LoginRequestDTO model )
        {
            var list = await _authService.Login(model);

            if( list == null )
                return BadRequest("Usuario y/o Contraseña inválidos!");

            var response = _tokenService.GenerateJwtToken(list);
            return Ok(response);
        }

        //[AllowAnonymous]
        //[SwaggerOperation(Summary = "Login")]
        //[HttpPost("LoginAD")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginResponseDTO))]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> LoginAD( LoginRequestDTO model )
        //{
        //    var list = await _authService.ActiveDirectoryAuthenticate(model);

        //    if( list == null )
        //        return BadRequest("Usuario y/o Contraseña inválidos!");

        //    var response = _tokenService.GenerateJwtToken(list);
        //    return Ok(response);
        //}

        #endregion
    }
}
