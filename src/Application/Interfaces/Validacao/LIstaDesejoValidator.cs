using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class ListaDesejoValidator : AbstractValidator<ListaDesejoDto>
{
    public ListaDesejoValidator()
    {
        RuleFor(x => x.Produtos)
            .NotNull().WithMessage(ListaDesejoMessages.ProdutosObrigatorio)
            .Must(produtos => produtos != null && produtos.Any())
            .WithMessage(ListaDesejoMessages.ProdutosMin1);

        RuleFor(x => x.ClienteId)
            .NotEmpty().WithMessage(ListaDesejoMessages.ClienteObrigatorio);
    }
}