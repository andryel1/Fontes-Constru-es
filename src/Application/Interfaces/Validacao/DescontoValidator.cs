using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class DescontoValidator : AbstractValidator<DescontoDto>
{
    public DescontoValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(DescontoMessages.NomeObrigatorio)
            .MaximumLength(100).WithMessage(DescontoMessages.NomeMax100);

        RuleFor(x => x.Valor)
            .GreaterThan(0).WithMessage(DescontoMessages.ValorMaiorQueZero);

        RuleFor(x => x.DataInicio)
            .NotNull().WithMessage(DescontoMessages.DataInicioObrigatoria);

        RuleFor(x => x.DataFim)
            .NotNull().WithMessage(DescontoMessages.DataFimObrigatoria);

        RuleFor(x => x.Produtos)
            .NotNull().WithMessage(DescontoMessages.ProdutosObrigatorio)
            .Must(produtos => produtos != null && produtos.Any())
            .WithMessage(DescontoMessages.ProdutosMin1);
    }
}