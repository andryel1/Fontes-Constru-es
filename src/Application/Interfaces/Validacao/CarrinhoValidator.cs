using FluentValidation;
using Application.Interfaces.Validacao;
using Application.Dtos;
using Resources.Messages;

public class CarrinhoValidator : AbstractValidator<CarrinhoDto>
{
    public CarrinhoValidator()
    {
        RuleFor(x => x.Itens)
            .NotNull().WithMessage(ItemCarrinhoMessages.ProdutoObrigatorio)
            .Must(itens => itens != null && itens.Any())
            .WithMessage(ItemCarrinhoMessages.ProdutoObrigatorio);

        RuleFor(x => x.ClienteId)
            .NotEmpty().WithMessage(ItemCarrinhoMessages.CarrinhoObrigatorio);
    }
}