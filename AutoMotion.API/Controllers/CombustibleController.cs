using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoMotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CombustibleController : ControllerBase
    {
        private readonly ICombustibleService _CombustibleService;

        public CombustibleController( ICombustibleService colorService )
        {
            _CombustibleService = colorService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert( CombustibleDTO model )
        {
            var resultado = await _CombustibleService.Insert(model);

            return Ok(resultado);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update( CombustibleDTO model )
        {
            var resultado = await _CombustibleService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete( int id )
        {
            await _CombustibleService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById( int id )
        {
            var resultado = await _CombustibleService.GetById(id);

            if( resultado == null )
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _CombustibleService.GetAll();

            return Ok(resultado);
        }
    }
}
