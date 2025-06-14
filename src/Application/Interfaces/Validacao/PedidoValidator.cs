using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class PedidoValidator : AbstractValidator<PedidoDto>
{
    public PedidoValidator()
    {
        RuleFor(x => x.Valor)
            .GreaterThan(0).WithMessage(PedidoMessages.ValorMaiorQueZero);

        RuleFor(x => x.TipoPagamento)
            .NotEmpty().WithMessage(PedidoMessages.TipoPagamentoObrigatorio);

        RuleFor(x => x.Status)
            .NotEmpty().WithMessage(PedidoMessages.StatusObrigatorio);

        RuleFor(x => x.DataPagamento)
            .NotNull().WithMessage(PedidoMessages.DataPagamentoObrigatoria);
    }
}