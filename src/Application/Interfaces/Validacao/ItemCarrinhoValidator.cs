using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;
using System.Data;

namespace Application.Interfaces.Validacao;
public class ItemCarrinhoValidator : AbstractValidator<ItemCarrinhoDto>
{
    public ItemCarrinhoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);

        RuleFor(x => x.ProdutoId)
            .NotEmpty().WithMessage(localizer[ItemCarrinhoMessages.ProdutoIdObrigatorio]);

        RuleFor(x => x.Quantidade)
            .NotEmpty().WithMessage(localizer[ItemCarrinhoMessages.QuantidadeObrigatoria])
            .GreaterThan(0).WithMessage(localizer[ItemCarrinhoMessages.QuantidadeMaiorQueZero]);

        RuleFor(x => x.Preco)
            .NotEmpty().WithMessage(localizer[ItemCarrinhoMessages.PrecoObrigatorio])
            .GreaterThan(0).WithMessage(localizer[ItemCarrinhoMessages.PrecoMaiorQueZero]);

        RuleFor(x => x.Carrinho)
            .NotNull().WithMessage(localizer[ItemCarrinhoMessages.CarrinhoObrigatorio]);

        RuleFor(x => x.Produto)
            .NotNull().WithMessage(localizer[ItemCarrinhoMessages.ProdutoObrigatorio]);

        RuleFor(x => x.CarrinhoId)
            .NotEmpty().WithMessage(localizer[ItemCarrinhoMessages.CarrinhoIdObrigatorio]);
    }
}