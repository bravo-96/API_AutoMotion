using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoMotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoresController : ControllerBase
    {
        private readonly IColorService _ColorService;

        public ColoresController( IColorService colorService )
        {
            _ColorService = colorService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert( ColorDTO model )
        {
            var resultado = await _ColorService.Insert(model);

            return Ok(resultado);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update( ColorDTO model )
        {
            var resultado = await _ColorService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete( int id )
        {
            await _ColorService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById( int id )
        {
            var resultado = await _ColorService.GetById(id);

            if( resultado == null )
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _ColorService.GetAll();

            return Ok(resultado);
        }
    }
}
