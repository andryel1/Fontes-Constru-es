using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;
using System.Data;

namespace Application.Interfaces.Validacao;

public class PedidoValidator : AbstractValidator<PedidoDto>
{
    public PedidoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);

        RuleFor(x => x.Id)
            .NotNull();

        RuleFor(x => x.DataPedido)
            .NotNull()
            .NotEmpty()
            .WithMessage(localizer[PedidoMessages.DataPagamentoObrigatoria]);

        RuleFor(x => x.InformacoesEnvio)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.ValorTotal)
        .NotNull()
        .WithMessage(localizer[PedidoMessages.ValorObrigatorio])
        .NotEmpty()
        .WithMessage(localizer[PedidoMessages.ValorMaiorQueZero]);

        RuleFor(x => x.Pagamentos)
            .NotNull()
            .WithMessage(localizer[PedidoMessages.TipoPagamentoObrigatorio])
            .Must(p => p != null && p.Count != 0)
            .WithMessage(localizer[PedidoMessages.TipoPagamentoInvalido]);

        RuleFor(x => x.DataEnvio)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Clientes)
           .NotNull()
           .NotEmpty();
           
        RuleFor(x => x.Itens)
           .NotNull()
           .NotEmpty();

        RuleFor(x => x.Status)
        .NotNull()
        .WithMessage(localizer[PedidoMessages.StatusObrigatorio])
        .NotEmpty()
        .WithMessage(localizer[PedidoMessages.StatusInvalido]);

        RuleFor(x => x.DataEntrega)
            .NotNull()
            .NotEmpty();
    }
}
