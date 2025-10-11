using System.Data;
using Application.Dtos;
using FluentValidation;
using Resources.Messages;

namespace Application.Interfaces.Validacao;
public class InformacoesEnvioValidator : AbstractValidator<InformacoesEnvioDto>
{
    public InformacoesEnvioValidator()
    {
        RuleFor(x => x.Endereco)
            .NotEmpty()
            .WithMessage(InformacoesMessages.EnderecoObrigatorio);

        RuleFor(x => x.Cidade)
            .NotEmpty()
            .WithMessage(InformacoesMessages.CidadeObrigatoria);

        RuleFor(x => x.Estado)
            .NotEmpty()
            .WithMessage(InformacoesMessages.EstadoObrigatorio);

        RuleFor(x => x.Cep)
            .NotEmpty()
            .WithMessage(InformacoesMessages.CepObrigatorio)
            .Length(8)
            .WithMessage(InformacoesMessages.CepInvalido);

        RuleFor(x => x.Telefone)
            .NotEmpty()
            .WithMessage(InformacoesMessages.TelefoneObrigatorio)
            .Matches(@"^[0-9]{10,11}$")
            .WithMessage(InformacoesMessages.TelefoneInvalido);

        RuleFor(x => x.NomeDestinatario)
            .NotEmpty()
            .WithMessage(InformacoesMessages.NomeDestinatarioObrigatorio);

        RuleFor(x => x.CpfDestinatario)
            .NotEmpty()
            .WithMessage(InformacoesMessages.CpfDestinatarioObrigatorio)
            .Length(11)
            .WithMessage(InformacoesMessages.CpfDestinatarioInvalido);

        RuleFor(x => x.EmailDestinatario)
            .NotEmpty()
            .WithMessage(InformacoesMessages.EmailDestinatarioObrigatorio)
            .EmailAddress()
            .WithMessage(InformacoesMessages.EmailDestinatarioInvalido);

        RuleFor(x => x.SobrenomeDestinatario)
            .NotNull()
            .NotEmpty()
            .MaximumLength(100)
            .WithMessage(InformacoesMessages.SobrenomeDestinatarioObrigatorio);

        RuleFor(x => x.DataDeEnvioPrevista)
            .NotEmpty()
            .NotNull()
            .WithMessage(InformacoesMessages.DataEnvioPrevistaObrigatoria);

        RuleFor(x => x.DatetimeEnvio)
            .NotNull()
            .NotEmpty()
            .WithMessage(InformacoesMessages.DataEnvioObrigatoria);

        RuleFor(x => x.Produto)
            .NotNull()
            .NotEmpty()
            .WithMessage(InformacoesMessages.ProdutoObrigatorio);

        RuleFor(x => x.ProdutoId)
            .NotNull()
            .NotEmpty()
            .WithMessage(InformacoesMessages.ProdutoIdObrigatorio);
    }
}