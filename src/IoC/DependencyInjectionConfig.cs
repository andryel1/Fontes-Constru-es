using Microsoft.Extensions.DependencyInjection;
using Application.Services;
using Application.Repository;

namespace IoC;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IProdutoService, ProdutoService>();

        return services;
    }
}
