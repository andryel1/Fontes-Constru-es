using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class DetalhamentoPedidoValidator : AbstractValidator<DetalhePedidoDto>
{
    public DetalhamentoPedidoValidator()
    {
        RuleFor(x => x.PedidoId)
            .NotEmpty().WithMessage(DetalheDoPedidoMessages.PedidoIdObrigatorio);

        RuleFor(x => x.ProdutoId)
            .NotEmpty().WithMessage(DetalheDoPedidoMessages.ProdutoIdObrigatorio);

        RuleFor(x => x.Quantidade)
            .GreaterThan(0).WithMessage(DetalheDoPedidoMessages.QuantidadeMaiorQueZero);
    }
}