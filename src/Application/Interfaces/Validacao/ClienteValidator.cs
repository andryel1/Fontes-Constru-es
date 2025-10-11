using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class ClienteValidator : AbstractValidator<ClienteDto>
{
    public ClienteValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty()
            .Length(3, 100)
            .WithMessage(ClienteMessages.NomeObrigatorio)
            .MaximumLength(200)
            .WithMessage(ClienteMessages.NomeMax200);

        RuleFor(x => x.Cpf)
            .NotEmpty()
            .WithMessage(ClienteMessages.CpfObrigatorio)
            .Must(cpf => cpf.ToString().Length == 11)
            .WithMessage(ClienteMessages.CpfInvalido);

        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage(ClienteMessages.EmailObrigatorio)
            .EmailAddress()
            .WithMessage(ClienteMessages.EmailInvalido);

        RuleFor(x => x.Password)
            .NotNull()
            .WithMessage(ClienteMessages.SenhaObrigatoria)
            .NotEmpty()
            .Must(x => x != null && x.Length > 8)
            .WithMessage(ClienteMessages.SenhaMin8);

        RuleFor(x => x.Telefone)
            .NotNull()
            .NotEmpty()
            .Matches(@"^[0-9]{10,11}$")
            .WithMessage(ClienteMessages.TelefoneInvalido);

        RuleFor(x => x.DataNascimento)
            .NotEmpty()
            .NotNull()
            .WithMessage(ClienteMessages.DataNascimentoInvalida);

        RuleFor(x => x.Id);
    }
}