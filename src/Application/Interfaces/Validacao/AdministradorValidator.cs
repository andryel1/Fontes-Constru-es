using System.Data;
using Application.Dtos;
using Ecommerce.Domain.Entities;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;
public class AdministradorValidator : AbstractValidator<AdministradorDto>
{
    public AdministradorValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);

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