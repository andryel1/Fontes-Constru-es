using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces.Service;
using Application.Service;

namespace IoC;

public static class DependencyInjectionConfig
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IPedidoService, PedidoService>();
        services.AddScoped<IPagamentoService, PagamentoService>();
        services.AddScoped<IItemCarrinhoService, ItemCarrinhoService>();
        services.AddScoped<IListaDesejoService, ListaDesejoService>();
        services.AddScoped<ITagService, TagService>();
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<ICarrinhoService, CarrinhoService>();

        return services;
    }
}
