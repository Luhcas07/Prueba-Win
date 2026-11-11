using WinServices.Api.Application.DTOs;

namespace WinServices.Api.Application.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDto>> BuscarAsync(string termino, int limite = 10, CancellationToken ct = default);
    }
}
