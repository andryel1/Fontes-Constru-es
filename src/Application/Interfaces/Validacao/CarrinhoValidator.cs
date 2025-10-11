using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao
{
    public class CarrinhoValidator : AbstractValidator<CarrinhoDto>
    {
        public CarrinhoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage(CarrinhoMessages.ItemInvalido);

            RuleFor(x => x.Itens)
                .NotNull()
                .WithMessage(CarrinhoMessages.NomeObrigatorio)
                .Must(itens => itens != null && itens.Count > 0)
                .WithMessage(CarrinhoMessages.ItemInvalido);

            RuleFor(x => x.ClienteId)
                .NotEmpty()
                .WithMessage(CarrinhoMessages.ModificacaoNaoPermitida);

            RuleFor(x => x.PedidoId)
                .NotEmpty()
                .NotNull()
                .WithMessage(CarrinhoMessages.ItemAdicionadoComSucesso);

            RuleFor(x => x.PrecoTotal)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage(CarrinhoMessages.ItemRemovidoComSucesso);

            RuleFor(x => x.DataCriacao)
                .NotEmpty()
                .NotNull()
                .WithMessage(CarrinhoMessages.NomeObrigatorio);
        }
    }
}