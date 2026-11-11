using WinServices.Api.Domain.Entities;

namespace WinServices.Api.Application.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> BuscarAsync(string termino, int limite = 10, CancellationToken ct = default);
    }
}
