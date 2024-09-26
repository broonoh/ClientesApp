namespace ClientesApp.API.Extensions;
/// <summary>
/// Classe de Extensão para configuração do Swagger na API da Omux Technology, versão 1.0
/// </summary>
public static class SwaggerExtension
{
    /// <summary>
    /// Método de Extensão para configuração do Swagger na API da Omux Technology
    /// </summary>
    public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
    {
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "Omux Technology API",
                Version = "v1",
                Description = "Api para gerenciamento de clientes e planos.",
                Contact = new Microsoft.OpenApi.Models.OpenApiContact
                {
                    Name = "Omux Technology",
                    Email = "atendimento@omux.com",
                    Url = new Uri("https://www.omux.com")
                },
                License = new Microsoft.OpenApi.Models.OpenApiLicense
                {
                    Name = "MIT License",
                    Url = new Uri("https://opensource.org/licenses/MIT")
                }
            });
        });
        return services;
    }

    /// <summary>
    /// Método de Extensão para configuração do Swagger na API da Omux Technology
    /// </summary>
    public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline.
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Clientes API v1");
        });
        return app;
    }
}