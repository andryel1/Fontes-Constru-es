using aplication.Interfaces.Services;
using Application.Dtos;
using Ecommerce.Domain.Entities;
using Application.Interfaces.Services;
using Application.Interfaces.Services;

namespace application.service;

public class PedidoService : IPedidoService
{
    private readonly IPedidoService _pedidoService;

    public PedidoService(IPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }
}
