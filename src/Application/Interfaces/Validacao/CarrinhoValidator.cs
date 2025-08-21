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
        RuleFor(x => x.Id);
        RuleFor(x => x.Itens)
            .NotNull().WithMessage(localizer[ItemCarrinhoMessages.ProdutoObrigatorio])
            .Must(itens => itens != null && itens.Count > 0)
            .WithMessage(localizer[ItemCarrinhoMessages.ProdutoObrigatorio]);

        RuleFor(x => x.ClienteId)
            .NotEmpty()
            .WithMessage(localizer[ItemCarrinhoMessages.CarrinhoObrigatorio]);
        RuleFor(x => x.PedidoId);
        RuleFor(x => x.PrecoTotal)
        .NotNull()
        .NotEmpty()
        .GreaterThan(0);
        RuleFor(x => x.DataCriacao);
    }
}