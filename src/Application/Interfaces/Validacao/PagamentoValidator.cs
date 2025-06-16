using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class PagamentoValidator : AbstractValidator<PagamentoDto>
{
    public PagamentoValidator()
    {
        RuleFor(x => x.Valor)
            .GreaterThan(0).WithMessage(PagamentoMessages.ValorMaiorQueZero);

        RuleFor(x => x.TipoPagamento)
            .NotEmpty().WithMessage(PagamentoMessages.TipoPagamentoObrigatorio);

        RuleFor(x => x.Status)
            .NotEmpty().WithMessage(PagamentoMessages.StatusObrigatorio);

        RuleFor(x => x.DataPagamento)
            .NotNull().WithMessage(PagamentoMessages.DataPagamentoObrigatoria);
    }
}