using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoMotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmisionController : ControllerBase
    {
        private readonly ITransmisionService _TransmisionService;

        public TransmisionController( ITransmisionService colorService )
        {
            _TransmisionService = colorService;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert( TransmisionDTO model )
        {
            var resultado = await _TransmisionService.Insert(model);

            return Ok(resultado);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update( TransmisionDTO model )
        {
            var resultado = await _TransmisionService.Update(model);

            return Ok(resultado);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete( int id )
        {
            await _TransmisionService.Delete(id);

            return Ok();
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById( int id )
        {
            var resultado = await _TransmisionService.GetById(id);

            if( resultado == null )
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _TransmisionService.GetAll();

            return Ok(resultado);
        }
    }
}
