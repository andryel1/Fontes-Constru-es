using Resources.Messages;
using Application.Dtos;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;
public class UsuarioValidator : AbstractValidator<AvaliacaoDto>
{
    public UsuarioValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
    }
}