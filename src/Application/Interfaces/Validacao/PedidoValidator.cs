using FluentValidation;
using Application.Dtos;
using Resources;

namespace Application.Interfaces.Validacao;
public class PedidoValidator : AbstractValidator<PedidoDto>
{
    public PedidoValidator()
    {

    }
}