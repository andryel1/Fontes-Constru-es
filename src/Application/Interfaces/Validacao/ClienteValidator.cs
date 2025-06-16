using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class ClienteValidator : AbstractValidator<ClienteDto>
{
    public ClienteValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(ClienteMessages.NomeObrigatorio)
            .MaximumLength(200).WithMessage(ClienteMessages.NomeMax200);

        RuleFor(x => x.Cpf)
            .NotEmpty().WithMessage(ClienteMessages.CpfObrigatorio)
            .Length(11).WithMessage(ClienteMessages.CpfInvalido);

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(ClienteMessages.EmailObrigatorio)
            .EmailAddress().WithMessage(ClienteMessages.EmailInvalido);

        RuleFor(x => x.Senha)
            .NotEmpty().WithMessage(ClienteMessages.SenhaObrigatoria)
            .MinimumLength(8).WithMessage(ClienteMessages.SenhaMin8);
    }
}