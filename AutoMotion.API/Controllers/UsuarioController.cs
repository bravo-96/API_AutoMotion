using AutoMotion.Authorization.Support.Helpers;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMotion.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtAuthenticationHandler.SchemeName)]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        #region Dependencias
        private readonly IUsuarioService _usuarioService;
        #endregion

        #region Constructor
        public UsuarioController(
            IUsuarioService usuarioService )
        {
            _usuarioService = usuarioService;
        }
        #endregion

        #region EndPoints

        [SwaggerOperation(Summary = "Obtiene un Colaborador por id")]
        [HttpGet("GetById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById( int id )
        {
            var list = await _usuarioService.GetById(id);

            if( list == null )
                return NotFound();

            return Ok(list);
        }

        [SwaggerOperation(Summary = "Obtiene la lista de Colaboradores")]
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UsuarioDTO>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            var list = await _usuarioService.GetAll();

            if( list == null )
                return NotFound();

            return Ok(list);
        }
        #endregion
    }
}
