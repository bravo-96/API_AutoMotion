using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoMotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase
    {
        private readonly IModeloService _ModeloService;

        public ModeloController( IModeloService colorService )
        {
            _ModeloService = colorService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert( ModeloDTO model )
        {
            var resultado = await _ModeloService.Insert(model);

            return Ok(resultado);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update( ModeloDTO model )
        {
            var resultado = await _ModeloService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete( int id )
        {
            await _ModeloService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById( int id )
        {
            var resultado = await _ModeloService.GetById(id);

            if( resultado == null )
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _ModeloService.GetAll();

            return Ok(resultado);
        }
    }
}
