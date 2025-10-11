using Application.Dtos;
using FluentValidation;

namespace Application.Interfaces.Validacao;
public class AdministradorValidator : AbstractValidator<AdministradorDto>
{
    public AdministradorValidator()
    {

        RuleFor(x => x.DataNascimento)
        .NotNull()
        .NotEmpty();

        RuleFor(x => x.Email)
        .NotEmpty()
        .NotNull();

        RuleFor(x => x.Password)
        .NotEmpty()
        .NotNull();

        RuleFor(x => x.UserNome)
        .NotEmpty()
        .NotNull();

        RuleFor(x => x.Id)
        .NotEmpty()
        .NotNull();

        RuleFor(x => x.Usuarios)
        .NotEmpty()
        .NotNull();
    }
}