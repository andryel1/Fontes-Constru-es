using Application.Dtos;
using FluentValidation;

namespace Application.Interfaces.Validacao;
public class AdministradorValidator : AbstractValidator<AdministradorDto>
{
    public AdministradorValidator()
    {

    }
}