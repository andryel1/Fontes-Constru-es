using Application.Dtos;
using FluentValidation;
using Resources.Messages;

public class AdministradorValidator : AbstractValidator<AdministradorDto>
{
    public AdministradorValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("Nome do administrador é obrigatório.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("E-mail do administrador é obrigatório.")
            .EmailAddress().WithMessage("E-mail do administrador inválido.");
    }
}