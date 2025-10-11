using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class ListaDesejoValidator : AbstractValidator<ListaDesejoDto>
{
    public ListaDesejoValidator()
    {
        RuleFor(x => x.DataAdicionada)
            .NotEmpty()
            .NotNull()
            .WithMessage(ListaDesejoMessages.DataAdicaoObrigatoria);

        RuleFor(x => x.Produtos)
            .NotEmpty()
            .WithMessage(ListaDesejoMessages.ProdutosObrigatorio);

        RuleFor(x => x.Clientes)
            .NotEmpty()
            .NotNull()
            .WithMessage(ListaDesejoMessages.ClienteObrigatorio);

        RuleFor(x => x.ClienteId);
    }
}