using FluentValidation;
using Application.Dtos;
using Resources;

namespace Application.Interfaces.Validacao;

public class ListaDesejoValidator : AbstractValidator<ListaDesejoDto>
{
    public ListaDesejoValidator()
    {
        
    }
}