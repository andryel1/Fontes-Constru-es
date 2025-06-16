using Application.Dtos;
using Resources;
using FluentValidation;
using Resources.Messages;

public class InformacoesEnvioValidator : AbstractValidator<InformacoesEnvioDto>
{
    public InformacoesEnvioValidator()
    {
        RuleFor(x => x.Endereco)
            .NotEmpty().WithMessage(InformacoesMessages.EnderecoObrigatorio);

        RuleFor(x => x.Cidade)
            .NotEmpty().WithMessage(InformacoesMessages.CidadeObrigatoria);

        RuleFor(x => x.Estado)
            .NotEmpty().WithMessage(InformacoesMessages.EstadoObrigatorio);

        RuleFor(x => x.Cep)
            .NotEmpty().WithMessage(InformacoesMessages.CepObrigatorio)
            .Length(8).WithMessage(InformacoesMessages.CepInvalido);

        RuleFor(x => x.Telefone)
            .NotEmpty().WithMessage(InformacoesMessages.TelefoneObrigatorio)
            .Matches(@"^[0-9]{10,11}$").WithMessage(InformacoesMessages.TelefoneInvalido);

        RuleFor(x => x.NomeDestinatario)
            .NotEmpty().WithMessage(InformacoesMessages.NomeDestinatarioObrigatorio);

        RuleFor(x => x.CpfDestinatario)
            .NotEmpty().WithMessage(InformacoesMessages.CpfDestinatarioObrigatorio)
            .Length(11).WithMessage(InformacoesMessages.CpfDestinatarioInvalido);

        RuleFor(x => x.EmailDestinatario)
            .NotEmpty().WithMessage(InformacoesMessages.EmailDestinatarioObrigatorio)
            .EmailAddress().WithMessage(InformacoesMessages.EmailDestinatarioInvalido);
    }
}