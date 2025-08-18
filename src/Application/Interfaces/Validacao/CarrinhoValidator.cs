using FluentValidation;
using Application.Dtos;
using Microsoft.Extensions.Localization;
using Resources.Messages;

namespace Application.Interfaces.Validacao;
public class CarrinhoValidator : AbstractValidator<CarrinhoDto>
{
    public CarrinhoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
        RuleFor(x => x.Itens)
            .NotNull().WithMessage(localizer[ItemCarrinhoMessages.ProdutoObrigatorio])
            .Must(itens => itens != null && itens.Any())
            .WithMessage(localizer[ItemCarrinhoMessages.ProdutoObrigatorio]);

        RuleFor(x => x.ClienteId)
            .NotEmpty().WithMessage(localizer[ItemCarrinhoMessages.CarrinhoObrigatorio]);
    }
}