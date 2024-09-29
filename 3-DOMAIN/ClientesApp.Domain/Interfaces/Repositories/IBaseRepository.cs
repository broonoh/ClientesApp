namespace ClientesApp.Domain.Interfaces.Repositories;
/// <summary>
/// Interface genérica para operações de repositório
/// </summary>
public interface IBaseRepository<TEntity,TKey> : IDisposable where TEntity : class 
{
    Task AddAsync (TEntity entity);
    Task UpdateAsync (TEntity entity);
    Task DeleteAsync (TEntity entity);
    Task <List<TEntity>> GetManyAsync (Func<TEntity, bool> where);
    Task <TEntity?> GetOneAsync(Func<TEntity, bool> where);
    Task <TEntity?> GetByIdAsync (TKey id);
}