using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class DetalhamentoPedidoValidator : AbstractValidator<DetalhePedidoDto>
{
    public DetalhamentoPedidoValidator()
    {
    }
}