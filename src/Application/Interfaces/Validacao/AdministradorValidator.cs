using Application.Dtos;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;
public class AdministradorValidator : AbstractValidator<AdministradorDto>
{
    public AdministradorValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
    }
}