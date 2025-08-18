using FluentValidation;
using Application.Dtos;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;

public class ListaDesejoValidator : AbstractValidator<ListaDesejoDto>
{
    public ListaDesejoValidator(IStringLocalizer localizer)
    {
      ArgumentNullException.ThrowIfNull(localizer);
    }
}