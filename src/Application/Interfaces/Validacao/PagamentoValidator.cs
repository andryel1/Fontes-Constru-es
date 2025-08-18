using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;

public class PagamentoValidator : AbstractValidator<PagamentoDto>
{
    public PagamentoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
        RuleFor(x => x.Valor)
            .GreaterThan(0).WithMessage(localizer[PagamentoMessages.ValorMaiorQueZero]);

        RuleFor(x => x.TipoPagamento)
            .NotEmpty().WithMessage(localizer[PagamentoMessages.TipoPagamentoObrigatorio]);

        RuleFor(x => x.Status)
            .NotEmpty().WithMessage(localizer[PagamentoMessages.StatusObrigatorio]);

        RuleFor(x => x.DataPagamento)
            .NotNull().WithMessage(localizer[PagamentoMessages.DataPagamentoObrigatoria]);
    }
}