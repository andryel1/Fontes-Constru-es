using FluentValidation;
using Application.Dtos;
using Resources.Messages;

public class ItemCarrinhoValidator : AbstractValidator<ItemCarrinhoDto>
{
    public ItemCarrinhoValidator()
    {
        RuleFor(x => x.ProdutoId)
            .NotEmpty().WithMessage(ItemCarrinhoMessages.ProdutoIdObrigatorio);

        RuleFor(x => x.Quantidade)
            .GreaterThan(0).WithMessage(ItemCarrinhoMessages.QuantidadeMaiorQueZero);

        RuleFor(x => x.Preco)
            .GreaterThan(0).WithMessage(ItemCarrinhoMessages.PrecoMaiorQueZero);
    }
}