using FluentValidation;
using Application.Dtos;
using Resources;

namespace Application.Interfaces.Validacao;
public class PagamentoValidator : AbstractValidator<PagamentoDto>
{
    public PagamentoValidator()
    {

    }
}