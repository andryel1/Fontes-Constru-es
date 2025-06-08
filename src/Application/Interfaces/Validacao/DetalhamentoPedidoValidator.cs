using FluentValidation;
using Application.Dtos;
using Resources;

namespace Application.Interfaces.Validacao;

public class DetalhePedidoValidator : AbstractValidator<DetalhePedidoDto>
{
    public DetalhePedidoValidator()
    {
        
    }
}