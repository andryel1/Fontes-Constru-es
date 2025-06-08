using FluentValidation;
using Resources;
using Application.Interfaces.Validacao;
using Application.Dtos;

public class CarrinhoValidator : AbstractValidator<CarrinhoDto>
{
    public CarrinhoValidator()
    {
        
    }
}