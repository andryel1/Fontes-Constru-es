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
            .NotEmpty().WithMessage(localizer[ClienteMessages.NomeObrigatorio])
            .MaximumLength(200).WithMessage(localizer[ClienteMessages.NomeMax200]);

        RuleFor(x => x.Cpf)
            .NotEmpty().WithMessage(localizer[ClienteMessages.CpfObrigatorio])
            .Must(cpf => cpf.ToString().Length == 11).WithMessage(localizer[ClienteMessages.CpfInvalido]);

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(localizer[ClienteMessages.EmailObrigatorio])
            .EmailAddress().WithMessage(localizer[ClienteMessages.EmailInvalido]);

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage(localizer[ClienteMessages.SenhaObrigatoria])
            .MinimumLength(8).WithMessage(localizer[ClienteMessages.SenhaMin8]);
    }
}