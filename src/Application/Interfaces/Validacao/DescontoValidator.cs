using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;

public class DescontoValidator : AbstractValidator<DescontoDto>
{
    public DescontoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
        
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(localizer[DescontoMessages.NomeObrigatorio])
            .MaximumLength(100).WithMessage(localizer[DescontoMessages.NomeMax100]);

        RuleFor(x => x.Valor)
            .GreaterThan(0).WithMessage(localizer[DescontoMessages.ValorMaiorQueZero]);

        RuleFor(x => x.DataInicio)
            .NotNull().WithMessage(localizer[DescontoMessages.DataInicioObrigatoria]);

        RuleFor(x => x.DataFim)
            .NotNull().WithMessage(localizer[DescontoMessages.DataFimObrigatoria]);

        RuleFor(x => x.Produtos)
            .NotNull().WithMessage(localizer[DescontoMessages.ProdutosObrigatorio])
            .Must(produtos => produtos != null && produtos.Any())
            .WithMessage(DescontoMessages.ProdutosMin1);
    }
}