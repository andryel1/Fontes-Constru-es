using System.Data;
using Application.Dtos;
using FluentValidation;
using Microsoft.Extensions.Localization;
using Resources.Messages;

namespace Application.Interfaces.Validacao;
public class InformacoesEnvioValidator : AbstractValidator<InformacoesEnvioDto>
{
    public InformacoesEnvioValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
        RuleFor(x => x.Endereco)
            .NotEmpty().WithMessage(localizer[InformacoesMessages.EnderecoObrigatorio]);

        RuleFor(x => x.Cidade)
            .NotEmpty().WithMessage(localizer[InformacoesMessages.CidadeObrigatoria]);

        RuleFor(x => x.Estado)
            .NotEmpty().WithMessage(localizer[InformacoesMessages.EstadoObrigatorio]);

        RuleFor(x => x.Cep)
            .NotEmpty().WithMessage(localizer[InformacoesMessages.CepObrigatorio])
            .Length(8).WithMessage(localizer[InformacoesMessages.CepInvalido]);

        RuleFor(x => x.Telefone)
            .NotEmpty().WithMessage(localizer[InformacoesMessages.TelefoneObrigatorio])
            .Matches(@"^[0-9]{10,11}$").WithMessage(localizer[InformacoesMessages.TelefoneInvalido]);

        RuleFor(x => x.NomeDestinatario)
            .NotEmpty().WithMessage(localizer[InformacoesMessages.NomeDestinatarioObrigatorio]);

        RuleFor(x => x.CpfDestinatario)
            .NotEmpty().WithMessage(localizer[InformacoesMessages.CpfDestinatarioObrigatorio])
            .Length(11).WithMessage(localizer[InformacoesMessages.CpfDestinatarioInvalido]);

        RuleFor(x => x.EmailDestinatario)
            .NotEmpty().WithMessage(localizer[InformacoesMessages.EmailDestinatarioObrigatorio])
            .EmailAddress().WithMessage(localizer[InformacoesMessages.EmailDestinatarioInvalido]);

        RuleFor(x => x.SobrenomeDestinatario)
        .NotNull()
        .NotEmpty()
        .MaximumLength(100)
        .WithMessage(localizer[InformacoesMessages.SobrenomeDestinatarioObrigatorio]);

        RuleFor(x => x.DataDeEnvioPrevista)
        .NotEmpty()
        .NotNull()
        .WithMessage(localizer[InformacoesMessages.DataEnvioPrevistaObrigatoria]);

        RuleFor(x => x.DatetimeEnvio)
        .NotNull()
        .NotEmpty()
        .WithMessage(localizer[InformacoesMessages.DataEnvioObrigatoria]);

        RuleFor(x => x.Produto)
        .NotNull()
        .NotEmpty()
        .WithMessage(localizer[InformacoesMessages.ProdutoObrigatorio]);

        RuleFor(x => x.ProdutoId)
        .NotNull()
        .NotEmpty()
        .WithMessage(localizer[InformacoesMessages.ProdutoIdObrigatorio]);
    }
}