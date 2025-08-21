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
            .NotEmpty();

        RuleFor(x => x.InformacoesEnvio)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Pagamentos)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.DataEnvio)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Clientes)
           .NotNull()
           .NotEmpty();

        RuleFor(x => x.Itens)
           .NotNull()
           .NotEmpty();

        RuleFor(x => x.DataEntrega)
            .NotNull()
            .NotEmpty();

         RuleFor(x => x.DataEnvio)
            .NotNull()
            .NotEmpty();
    }
}
