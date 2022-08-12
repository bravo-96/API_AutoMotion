using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoMotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoService _VehiculoService;

        public VehiculoController( IVehiculoService colorService )
        {
            _VehiculoService = colorService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert( VehiculoDTO model )
        {
            var resultado = await _VehiculoService.Insert(model);

            return Ok(resultado);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update( VehiculoDTO model )
        {
            var resultado = await _VehiculoService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete( int id )
        {
            await _VehiculoService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById( int id )
        {
            var resultado = await _VehiculoService.GetById(id);

            if( resultado == null )
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _VehiculoService.GetAll();

            return Ok(resultado);
        }
    }
}
