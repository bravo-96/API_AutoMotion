using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoMotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoController : ControllerBase
    {
        private readonly ITipoService _TipoService;

        public TipoController( ITipoService colorService )
        {
            _TipoService = colorService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert( TipoDTO model )
        {
            var resultado = await _TipoService.Insert(model);

            return Ok(resultado);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update( TipoDTO model )
        {
            var resultado = await _TipoService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete( int id )
        {
            await _TipoService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById( int id )
        {
            var resultado = await _TipoService.GetById(id);

            if( resultado == null )
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _TipoService.GetAll();

            return Ok(resultado);
        }
    }
}
