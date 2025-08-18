using FluentValidation;
using Application.Dtos;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;

public class DetalhamentoPedidoValidator : AbstractValidator<DetalhePedidoDto>
{
    public DetalhamentoPedidoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
    }
}