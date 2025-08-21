using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;
public class ItemCarrinhoValidator : AbstractValidator<ItemCarrinhoDto>
{
    public ItemCarrinhoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);

        RuleFor(x => x.Id);
        RuleFor(x => x.ProdutoId)
            .NotEmpty().WithMessage(localizer[ItemCarrinhoMessages.ProdutoIdObrigatorio]);

        RuleFor(x => x.Quantidade)
            .GreaterThan(0).WithMessage(localizer[ItemCarrinhoMessages.QuantidadeMaiorQueZero]);

        RuleFor(x => x.Preco)
            .GreaterThan(0).WithMessage(localizer[ItemCarrinhoMessages.PrecoMaiorQueZero]);

        RuleFor(x => x.Carrinho);

        RuleFor(x => x.Produto);

        RuleFor(x => x.CarrinhoId);
    }
}