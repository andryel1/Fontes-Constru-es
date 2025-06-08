using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces.Service;
using Application.Service;
using FluentValidation;
using Application.Dtos;
using Application.Interfaces.Validacao;

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
        services.AddScoped<IInformacoesEnvioService, InformacoesEnvioService>();
        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddScoped<IDescontoService, DescontoService>();
        services.AddScoped<IAvaliacaoService, AvaliacaoService>();
        services.AddScoped<ICategoriaService, CategoriaService>();
        services.AddScoped<IClienteService, ClienteService>();
        services.AddScoped<IDetalhePedidoService, DetalhePedidoService>();
        services.AddScoped<IImagemService, ImagemService>();    
        services.AddScoped<IEnviarEmailService, EnviarEmailService>();
        services.AddScoped<IItemCarrinhoService, ItemCarrinhoService>();

        //Referência de  Validações
        services.AddScoped<IValidator<TagDto>, TagValidator>();

        return services;
    }
}
