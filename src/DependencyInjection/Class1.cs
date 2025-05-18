using DependencyInjectionSample.Interfaces;
using DependencyInjectionSample.Services;
using Microsoft.Extensions.DependencyInjection;
namespace IoC;

public class Class1
{
addScoped<IProdutoService, ProdutoService>();
    addScoped<ICategoriaService, CategoriaService>();
    addScoped<IAvaliacaoService, AvaliacaoService>();
    addScoped<IImagemService, ImagemService>();
    addScoped<IClienteService, ClienteService>();
    addScoped<IPedidoService, PedidoService>();
}
