using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;

public class PedidoValidator : AbstractValidator<PedidoDto>
{
    public PedidoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
    }
}