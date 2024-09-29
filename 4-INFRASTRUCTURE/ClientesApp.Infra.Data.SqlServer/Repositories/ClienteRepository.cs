using ClientesApp.Domain.Entities;
using ClientesApp.Domain.Interfaces.Repositories;

namespace ClientesApp.Infra.Data.SqlServer.Repositories;

public class ClienteRepository : BaseRepository<Cliente, Guid>, IClienteRepository
{
    
}