using FluentValidation;
using Application.Dtos;
using Resources;

namespace Application.Interfaces.Validacao;

public class ProdutoValidator : AbstractValidator<ProdutoDto>
{
    public ProdutoValidator()
    {
       
    }
}