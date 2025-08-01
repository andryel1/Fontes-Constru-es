using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces.Service;
using Application.Interfaces.Repository;
using Application.Service;
using FluentValidation;
using Application.Interfaces.Validacao;
using Application.Dtos;

using Infrastructure.Repository;

namespace IoC;

public static class DependencyInjectionConfig
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        Service(services);
        Validator(services);
        Repository(services);
        return services;
    }

    private static void Repository(IServiceCollection services)
    {
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
    
    } 

    private static void Service(IServiceCollection services)
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
      //  services.AddScoped<IAuthService, AuthService>();
    }


        private static void Validator(IServiceCollection services)
    {
        services.AddScoped<IValidator<TagDto>, TagValidator>();
        // services.AddScoped<IValidator<UsuarioDto>, UsuarioValidator>();
        services.AddScoped<IValidator<AdministradorDto>, AdministradorValidator>();
        services.AddScoped<IValidator<AvaliacaoDto>, AvaliacaoValidator>();
        services.AddScoped<IValidator<CarrinhoDto>, CarrinhoValidator>();
        services.AddScoped<IValidator<CategoriaDto>, CategoriaValidator>();
        services.AddScoped<IValidator<ClienteDto>, ClienteValidator>();
        services.AddScoped<IValidator<DescontoDto>, DescontoValidator>();
        // services.AddScoped<IValidator<DetalhamentoPedidoDto>, DetalhamentoPedidoValidator>();
        services.AddScoped<IValidator<ImagemDto>, ImagemValidator>();
        services.AddScoped<IValidator<InformacoesEnvioDto>, InformacoesEnvioValidator>();
        services.AddScoped<IValidator<ItemCarrinhoDto>, ItemCarrinhoValidator>();
        services.AddScoped<IValidator<ListaDesejoDto>, ListaDesejoValidator>();
        services.AddScoped<IValidator<PagamentoDto>, PagamentoValidator>();
        services.AddScoped<IValidator<PedidoDto>, PedidoValidator>();
    }

}
