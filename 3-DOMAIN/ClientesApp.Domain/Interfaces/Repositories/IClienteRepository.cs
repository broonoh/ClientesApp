using ClientesApp.Domain.Entities;

namespace ClientesApp.Domain.Interfaces.Repositories;

public interface IClienteRepository : IBaseRepository<Cliente, Guid>
{
    
}