using aplication.Interfaces.Repository;
using Application.Dtos;
using Ecommerce.Domain.Entities;
using Application.Interfaces.Repository;
using Application.Interfaces.Services;

namespace Application.service;

public class ItemCarrinhoService : IItemCarrinhoService
{
    private readonly IItemCarrinhoRepository _itemCarrinhoRepository;

    public ItemCarrinhoService(IItemCarrinhoRepository itemCarrinhoRepository)
    {
        _itemCarrinhoRepository = itemCarrinhoRepository;
    }
}