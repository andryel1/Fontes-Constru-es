using FluentValidation;
using Application.Dtos;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;

public class DetalhamentoPedidoValidator : AbstractValidator<DetalhePedidoDto>
{
    public DetalhamentoPedidoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);

        RuleFor(x => x.NomeProduto);
        RuleFor(x => x.Pedido);
        RuleFor(x => x.PedidoId);
        RuleFor(x => x.Preco);
        RuleFor(x => x.Quantidade);
        RuleFor(x => x.SubTotal);
    }
}