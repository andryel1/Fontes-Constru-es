using FluentValidation;
using Application.Dtos;

namespace Application.Interfaces.Validacao;

public class ListaDesejoValidator : AbstractValidator<ListaDesejoDto>
{
    public ListaDesejoValidator()
    {

    }
}