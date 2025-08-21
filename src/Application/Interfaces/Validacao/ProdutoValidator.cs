using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;
using System.Data;

namespace Application.Interfaces.Validacao;

public class ProdutoValidator : AbstractValidator<ProdutoDto>
{
    public ProdutoValidator(IStringLocalizer localizer)
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(localizer[ProdutoMessages.NomeObrigatorio])
            .MaximumLength(200).WithMessage(localizer[ProdutoMessages.NomeMax200]);

        RuleFor(x => x.Descricao)
            .NotEmpty().WithMessage(localizer[ProdutoMessages.DescricaoObrigatoria])
            .MaximumLength(500).WithMessage(localizer[ProdutoMessages.DescricaoMax500]);

        RuleFor(x => x.Preco)
            .GreaterThan(0).WithMessage(localizer[ProdutoMessages.PrecoMaiorQueZero]);

        RuleFor(x => x.Estoque)
            .NotNull().WithMessage(localizer[ProdutoMessages.EstoqueObrigatorio]);

        RuleFor(x => x.Imagens)
            .NotNull().WithMessage(localizer[ProdutoMessages.ImagensObrigatorio]);

        RuleFor(x => x.Categorias)
            .NotNull().WithMessage(localizer[ProdutoMessages.CategoriasObrigatorio]);

           RuleFor(x => x.Avaliacoes)
          .NotNull();

         RuleFor(x => x.Tags)
           .NotNull();

         RuleFor(x => x.ItensCarrinho);

         RuleFor(x => x.ListaDesejos);

         RuleFor(x => x.Pedidos);
    }
}