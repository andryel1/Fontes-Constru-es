using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using System.Text.RegularExpressions;

namespace Application.Interfaces.Validacao
{
    public class TagValidator : AbstractValidator<TagDto>
    {
        public TagValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage(TagMessages.ValorDeveSerMaiorQueZero);

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(TagMessages.DescricaoObrigatoria)
                .MaximumLength(200)
                .WithMessage(TagMessages.DescricaoMax200)
                .Must(nome => !string.IsNullOrWhiteSpace(nome))
                .WithMessage(TagMessages.NomeNaoPodeSerApenasEspacos)
                .Must(nome => nome == nome.Trim())
                .WithMessage(TagMessages.NomeNaoDeveTerEspacosExtremos)
                .Must(nome => !Regex.IsMatch(nome, @"[<>]"))
                .WithMessage(TagMessages.NomeNaoPodeTerCaracteresEspeciais);

            RuleFor(x => x.Produtos)
                .NotNull()
                .WithMessage(TagMessages.ListaProdutosNaoPodeSerNula)
                .Must(produtos => produtos != null && produtos.Any())
                .WithMessage(TagMessages.TagDeveTerProduto);
        }
    }
}
