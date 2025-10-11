using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class DetalhamentoPedidoValidator : AbstractValidator<DetalhePedidoDto>
{
    public DetalhamentoPedidoValidator()
    {
        RuleFor(x => x.NomeProduto)
            .NotEmpty()
            .WithMessage(DetalhePedidoMessages.NomeObrigatorio)
            .MaximumLength(100)
            .WithMessage(DetalhePedidoMessages.NomeMax100)
            .Must(nome => !string.IsNullOrWhiteSpace(nome))
            .WithMessage(DetalhePedidoMessages.NomeObrigatorio);

        RuleFor(x => x.Pedido)
            .NotNull()
            .WithMessage(DetalhePedidoMessages.PedidoIdObrigatorio);

        RuleFor(x => x.PedidoId)
            .NotEmpty()
            .WithMessage(DetalhePedidoMessages.PedidoIdObrigatorio)
            .GreaterThan(0)
            .WithMessage(DetalhePedidoMessages.PedidoIdInvalido);

        RuleFor(x => x.Preco)
            .NotEmpty()
            .WithMessage(DetalhePedidoMessages.PrecoObrigatorio)
            .GreaterThan(0)
            .WithMessage(DetalhePedidoMessages.PrecoInvalido);

        RuleFor(x => x.Quantidade)
            .NotEmpty()
            .WithMessage(DetalhePedidoMessages.QuantidadeObrigatoria)
            .GreaterThan(0)
            .WithMessage(DetalhePedidoMessages.QuantidadeInvalida);

        RuleFor(x => x.SubTotal)
            .GreaterThan(0)
            .WithMessage(DetalhePedidoMessages.PrecoInvalido);
    }
}