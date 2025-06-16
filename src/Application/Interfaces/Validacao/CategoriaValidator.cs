using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;
public class CategoriaValidator : AbstractValidator<CategoriaDto>
{
    public CategoriaValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(CategoriaMessages.NomeObrigatorio)
            .MaximumLength(100).WithMessage(CategoriaMessages.NomeMax100);

        RuleFor(x => x.Produtos)
            .NotNull().WithMessage(CategoriaMessages.ProdutosObrigatorio)
            .Must(produtos => produtos != null && produtos.Any())
            .WithMessage(CategoriaMessages.ProdutosMin1);
    }
}