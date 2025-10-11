using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class PedidoValidator : AbstractValidator<PedidoDto>
{
    public PedidoValidator()
    {
        RuleFor(x => x.Id)
            .NotNull();

        RuleFor(x => x.DataPedido)
            .NotNull()
            .NotEmpty()
            .WithMessage(PedidoMessages.DataPagamentoObrigatoria);

        RuleFor(x => x.InformacoesEnvio)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.ValorTotal)
            .NotNull()
            .WithMessage(PedidoMessages.ValorObrigatorio)
            .NotEmpty()
            .WithMessage(PedidoMessages.ValorMaiorQueZero);

        RuleFor(x => x.Pagamentos)
            .NotNull()
            .WithMessage(PedidoMessages.TipoPagamentoObrigatorio)
            .Must(p => p != null && p.Count != 0)
            .WithMessage(PedidoMessages.TipoPagamentoInvalido);

        RuleFor(x => x.DataEnvio)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.ClienteId)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Itens)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Status)
            .NotNull()
            .WithMessage(PedidoMessages.StatusObrigatorio)
            .NotEmpty()
            .WithMessage(PedidoMessages.StatusInvalido);

        RuleFor(x => x.DataEntrega)
            .NotNull()
            .NotEmpty();
    }
}