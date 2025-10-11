using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;
public class ItemCarrinhoValidator : AbstractValidator<ItemCarrinhoDto>
{
    public ItemCarrinhoValidator()
    {
        RuleFor(x => x.ProdutoId)
            .NotEmpty()
            .WithMessage(ItemCarrinhoMessages.ProdutoIdObrigatorio);

        RuleFor(x => x.Quantidade)
            .NotEmpty()
            .WithMessage(ItemCarrinhoMessages.QuantidadeObrigatoria)
            .GreaterThan(0)
            .WithMessage(ItemCarrinhoMessages.QuantidadeMaiorQueZero);

        RuleFor(x => x.Preco)
            .NotEmpty()
            .WithMessage(ItemCarrinhoMessages.PrecoObrigatorio)
            .GreaterThan(0)
            .WithMessage(ItemCarrinhoMessages.PrecoMaiorQueZero);

        RuleFor(x => x.Carrinho)
            .NotNull()
            .WithMessage(ItemCarrinhoMessages.CarrinhoObrigatorio);

        RuleFor(x => x.Produto)
            .NotNull()
            .WithMessage(ItemCarrinhoMessages.ProdutoObrigatorio);

        RuleFor(x => x.CarrinhoId)
            .NotEmpty()
            .WithMessage(ItemCarrinhoMessages.CarrinhoIdObrigatorio);
    }
}