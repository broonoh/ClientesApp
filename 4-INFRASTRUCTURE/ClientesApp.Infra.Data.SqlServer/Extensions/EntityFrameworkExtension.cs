using ClientesApp.Infra.Data.SqlServer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClientesApp.Infra.Data.SqlServer.Extensions;

/// <summary>
/// Classe de extensão para configurarmos as injeções de dependência
/// do projeto Infra.Data e do EntityFramework
/// </summary>
public static class EntityFrameworkExtension
{
    public static IServiceCollection AddEntityFramework
    (this IServiceCollection services,
        IConfiguration configuration)

    {
        var connectionString = configuration.GetConnectionString

            ("ClientesApp");
        services.AddDbContext<DataContext>

            (options => options.UseSqlServer(connectionString));

        return services;
    }
}

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseSqlServer("Server=localhost,1433; User Id=sa; Password=Ecopi@185; Encrypt=False; Database=ClientesApp;");

        return new DataContext(optionsBuilder.Options);
    }
}
