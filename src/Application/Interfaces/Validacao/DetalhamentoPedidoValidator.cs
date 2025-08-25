using FluentValidation;
using Application.Dtos;
using Microsoft.Extensions.Localization;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class DetalhamentoPedidoValidator : AbstractValidator<DetalhePedidoDto>
{
    public DetalhamentoPedidoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);

        RuleFor(x => x.NomeProduto)
            .NotEmpty().WithMessage(localizer[DetalhePedidoMessages.NomeObrigatorio])
            .MaximumLength(100).WithMessage(localizer[DetalhePedidoMessages.NomeMax100])
            .Must(nome => !string.IsNullOrWhiteSpace(nome)).WithMessage(localizer[DetalhePedidoMessages.NomeObrigatorio]);

        RuleFor(x => x.Pedido)
            .NotNull().WithMessage(localizer[DetalhePedidoMessages.PedidoIdObrigatorio]);

        RuleFor(x => x.PedidoId)
            .NotEmpty().WithMessage(localizer[DetalhePedidoMessages.PedidoIdObrigatorio])
            .GreaterThan(0).WithMessage(localizer[DetalhePedidoMessages.PedidoIdInvalido]);

        RuleFor(x => x.Preco)
            .NotEmpty().WithMessage(localizer[DetalhePedidoMessages.PrecoObrigatorio])
            .GreaterThan(0).WithMessage(localizer[DetalhePedidoMessages.PrecoInvalido]);

        RuleFor(x => x.Quantidade)
            .NotEmpty().WithMessage(localizer[DetalhePedidoMessages.QuantidadeObrigatoria])
            .GreaterThan(0).WithMessage(localizer[DetalhePedidoMessages.QuantidadeInvalida]);

        RuleFor(x => x.SubTotal)
            .GreaterThan(0).WithMessage(localizer[DetalhePedidoMessages.PrecoInvalido]);
    }
}