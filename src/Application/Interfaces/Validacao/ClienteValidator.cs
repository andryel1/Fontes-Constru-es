using Resources;
using FluentValidation;
using Application.Dtos;

namespace Application.Interfaces.Validacao;

public class ClienteValidator : AbstractValidator<DescontoDto>
{
    public ClienteValidator()
    {
    
    }  
}