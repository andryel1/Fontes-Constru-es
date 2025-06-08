using Resources;
using FluentValidation;
using Application.Dtos;

namespace Application.Interfaces.Validacao;

public class DescontoValidator : AbstractValidator<DescontoDto>
{
    public DescontoValidator()
    {
    
    }  
}