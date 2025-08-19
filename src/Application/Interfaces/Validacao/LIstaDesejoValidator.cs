using FluentValidation;
using Application.Dtos;
using Microsoft.Extensions.Localization;
using Resources.Messages;
using System.Data;

namespace Application.Interfaces.Validacao;

public class ListaDesejoValidator : AbstractValidator<ListaDesejoDto>
{
  public ListaDesejoValidator(IStringLocalizer localizer)
  {
    ArgumentNullException.ThrowIfNull(localizer);

    RuleFor(x => x.DataAdicionada)
      .NotEmpty()
      .NotNull()
      .WithMessage(localizer[ListaDesejoMessages.DataAdicaoObrigatoria]);

      RuleFor(x => x.Produtos)
        .NotEmpty()
        .WithMessage(localizer[ListaDesejoMessages.ProdutosObrigatorio]);
  }
}