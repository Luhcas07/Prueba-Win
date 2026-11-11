using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using WinServices.Api.Application.Interfaces;
using WinServices.Api.Infrastructure.Http;

namespace WinServices.Api.Api.Controllers
{

    [ApiController]
    [Route("api/v1/clientes")]
    [ApiVersion(1.0)]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;
        private readonly ExampleHttpService _httpService;

        public ClienteController(IClienteService service, ExampleHttpService httpService)
        {
            _service = service;
            _httpService = httpService;
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> GetAll([FromQuery] string termino, [FromQuery] int limite = 10)
        {
            if(termino.Length < 3)
            {
                return BadRequest(new { error = "Término tiene menos de 3 carácteres." });
            }
            var items = await _service.BuscarAsync(termino, limite);
            return Ok(items);
        }
    }
}
