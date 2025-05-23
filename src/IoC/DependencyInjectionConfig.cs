using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces.Services;
using Ecommerce.Domain.Entities;
using Application.Service;


namespace IoC;

public static class DependencyInjectionConfig
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<ICategoriaService, CategoriaService>();
        return services;
    }
}
