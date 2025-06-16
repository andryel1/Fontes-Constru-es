using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class ProdutoValidator : AbstractValidator<ProdutoDto>
{
    public ProdutoValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(ProdutoMessages.NomeObrigatorio)
            .MaximumLength(200).WithMessage(ProdutoMessages.NomeMax200);

        RuleFor(x => x.Descricao)
            .NotEmpty().WithMessage(ProdutoMessages.DescricaoObrigatoria)
            .MaximumLength(500).WithMessage(ProdutoMessages.DescricaoMax500);

        RuleFor(x => x.Preco)
            .GreaterThan(0).WithMessage(ProdutoMessages.PrecoMaiorQueZero);

        RuleFor(x => x.Estoque)
            .NotNull().WithMessage(ProdutoMessages.EstoqueObrigatorio);

        RuleFor(x => x.Imagens)
            .NotNull().WithMessage(ProdutoMessages.ImagensObrigatorio);

        RuleFor(x => x.Categorias)
            .NotNull().WithMessage(ProdutoMessages.CategoriasObrigatorio);
    }
}