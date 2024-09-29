using ClientesApp.Infra.Data.SqlServer.Mappins;
using Microsoft.EntityFrameworkCore;

namespace ClientesApp.Infra.Data.SqlServer.Contexts;
/// <summary>
/// Classe de contexto para configuração do acesso ao banco de dados feito pelo Entity Framework
/// </summary>
public class DataContext : DbContext
{
    //Contrutor
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteMap());
    }
}