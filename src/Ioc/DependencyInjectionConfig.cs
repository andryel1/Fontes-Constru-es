using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces.Service;
using Application.Interfaces.Repository;
using Application.Service;
using FluentValidation;
using Application.Interfaces.Validacao;
using Application.Dtos;
using Infrastructure.Repositories;

using Infrastructure.Repository; 

namespace IoC;

public static class DependencyInjectionConfig
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddLocalization(); 

        Service(services);
        Validator(services);
        Repository(services);
        return services;
    }

    private static void Repository(IServiceCollection services)
    {
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IPedidoRepository, PedidoRepository>();
        services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
        services.AddScoped<IDescontoRepository, DescontoRepository>();
        services.AddScoped<ICarrinhoRepository, CarrinhoRepository>();

    } 

    private static void Service(IServiceCollection services)
    {
        services.AddScoped<IPagamentoService, PagamentoService>();
        services.AddScoped<IItemCarrinhoService, ItemCarrinhoService>();
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
    }

    private static void Validator(IServiceCollection services)
    {
        services.AddScoped<IValidator<TagDto>, TagValidator>();
        services.AddScoped<IValidator<AdministradorDto>, AdministradorValidator>();
        services.AddScoped<IValidator<AvaliacaoDto>, AvaliacaoValidator>();
        services.AddScoped<IValidator<CarrinhoDto>, CarrinhoValidator>();
        services.AddScoped<IValidator<CategoriaDto>, CategoriaValidator>();
        services.AddScoped<IValidator<ClienteDto>, ClienteValidator>();
        services.AddScoped<IValidator<DescontoDto>, DescontoValidator>();
        services.AddScoped<IValidator<ImagemDto>, ImagemValidator>();
        services.AddScoped<IValidator<InformacoesEnvioDto>, InformacoesEnvioValidator>();
        services.AddScoped<IValidator<ItemCarrinhoDto>, ItemCarrinhoValidator>();
        services.AddScoped<IValidator<ListaDesejoDto>, ListaDesejoValidator>();
        services.AddScoped<IValidator<PagamentoDto>, PagamentoValidator>();
    }
}