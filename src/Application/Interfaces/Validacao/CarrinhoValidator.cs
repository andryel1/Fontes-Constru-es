using FluentValidation;
using Application.Dtos;
using Microsoft.Extensions.Localization;
using Resources.Messages;

namespace Application.Interfaces.Validacao
{
    public class CarrinhoValidator : AbstractValidator<CarrinhoDto>
    {
        public CarrinhoValidator(IStringLocalizer localizer)
        {
            ArgumentNullException.ThrowIfNull(localizer);

            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage(localizer[CarrinhoMessages.ItemInvalido]);

            RuleFor(x => x.Itens)
                .NotNull()
                .WithMessage(localizer[CarrinhoMessages.NomeObrigatorio])
                .Must(itens => itens != null && itens.Count > 0)
                .WithMessage(localizer[CarrinhoMessages.ItemInvalido]);

            RuleFor(x => x.ClienteId)
                .NotEmpty()
                .WithMessage(localizer[CarrinhoMessages.ModificacaoNaoPermitida]);

            RuleFor(x => x.PedidoId)
                .NotEmpty()
                .NotNull()
                .WithMessage(localizer[CarrinhoMessages.ItemAdicionadoComSucesso]);

            RuleFor(x => x.PrecoTotal)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage(localizer[CarrinhoMessages.ItemRemovidoComSucesso]);

            RuleFor(x => x.DataCriacao)
                .NotEmpty()
                .NotNull()
                .WithMessage(localizer[CarrinhoMessages.NomeObrigatorio]);
        }
    }
}
