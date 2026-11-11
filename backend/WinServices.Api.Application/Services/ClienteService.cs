using Microsoft.Extensions.Logging;
using WinServices.Api.Application.Common;
using WinServices.Api.Application.DTOs;
using WinServices.Api.Application.Interfaces;
using WinServices.Api.Application.Mapping;

namespace WinServices.Api.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly ILogger<ClienteService> _logger;

        public ClienteService(
            IClienteRepository repository,
            ILogger<ClienteService> logger)
        {
            _repository = repository;
            _logger = logger;
        }


        public async Task<IEnumerable<ClienteDto>> BuscarAsync(string termino, int limite = 10, CancellationToken ct = default)
        {
            var items = await _repository.BuscarAsync(termino, limite, ct);
            return items.ToDtoList();
        }
    }
}
