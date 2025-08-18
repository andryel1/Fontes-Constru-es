using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;
public class CategoriaValidator : AbstractValidator<CategoriaDto>
{
    public CategoriaValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(localizer[CategoriaMessages.NomeObrigatorio])
            .MaximumLength(100).WithMessage(CategoriaMessages.NomeMax100);

        RuleFor(x => x.Produtos)
            .NotNull().WithMessage(CategoriaMessages.ProdutosObrigatorio)
            .Must(produtos => produtos != null && produtos.Any())
            .WithMessage(CategoriaMessages.ProdutosMin1);
    }
}