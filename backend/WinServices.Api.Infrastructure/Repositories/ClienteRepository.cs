using Dapper;
using System.Data;
using WinServices.Api.Application.Interfaces;
using WinServices.Api.Domain.Entities;
using WinServices.Api.Infrastructure.Data;

namespace WinServices.Api.Infrastructure.Repositories
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        public ClienteRepository(IDbConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<IEnumerable<Cliente>> BuscarAsync(string termino, int limite = 10, CancellationToken ct = default)
        {
            using var connection = ConnectionFactory.CreateConnection();
            return await connection.QueryAsync<Cliente>(
                "dbo.usp_Cliente_Buscar",
                commandType: CommandType.StoredProcedure
            );
        }
    }
}
