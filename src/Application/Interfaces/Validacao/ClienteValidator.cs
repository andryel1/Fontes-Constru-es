using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;

public class ClienteValidator : AbstractValidator<ClienteDto>
{
    public ClienteValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);

        RuleFor(x => x.Nome)
            .NotEmpty()
            .Length(3, 100)
            .WithMessage(localizer[ClienteMessages.NomeObrigatorio])
            .MaximumLength(200).WithMessage(localizer[ClienteMessages.NomeMax200]);

        RuleFor(x => x.Cpf)
            .NotEmpty().WithMessage(localizer[ClienteMessages.CpfObrigatorio])
            .Must(cpf => cpf.ToString().Length == 11).WithMessage(localizer[ClienteMessages.CpfInvalido]);

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(localizer[ClienteMessages.EmailObrigatorio])
            .EmailAddress().WithMessage(localizer[ClienteMessages.EmailInvalido]);

        RuleFor(x => x.Password)
            .NotNull()
            .WithMessage(localizer[ClienteMessages.SenhaObrigatoria])
            .NotEmpty()
            .Must(x => x != null && x.Length > 8)
            .WithMessage(localizer[ClienteMessages.SenhaMin8]);


        RuleFor(x => x.Telefone)
            .NotNull()
            .NotEmpty()
            .Matches(@"^[0-9]{10,11}$")
            .WithMessage(localizer[ClienteMessages.TelefoneInvalido]);

        RuleFor(x => x.DataNascimento)
            .NotEmpty()
            .NotNull()
            .WithMessage(localizer[ClienteMessages.DataNascimentoInvalida]);

        RuleFor(x => x.Id);
    }
}