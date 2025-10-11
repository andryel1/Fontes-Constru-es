using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class DescontoValidator : AbstractValidator<DescontoDto>
{
    public DescontoValidator()
    {
        RuleFor(x => x.Valor)
            .GreaterThan(0)
            .WithMessage(DescontoMessages.ValorMaiorQueZero);

        RuleFor(x => x.DataInicio)
            .NotNull()
            .WithMessage(DescontoMessages.DataInicioObrigatoria);

        RuleFor(x => x.DataFim)
            .NotNull()
            .WithMessage(DescontoMessages.DataFimObrigatoria);

        RuleFor(x => x.Produtos)
            .NotNull()
            .WithMessage(DescontoMessages.ProdutosObrigatorio)
            .Must(produtos => produtos != null && produtos.Any())
            .WithMessage(DescontoMessages.ProdutosMin1);

        RuleFor(x => x.Ativo)
            .NotNull()
            .WithMessage(DescontoMessages.AtivoObrigatorio);

        RuleFor(x => x.Id);

        RuleFor(x => x.ProdutoId);
    }
}