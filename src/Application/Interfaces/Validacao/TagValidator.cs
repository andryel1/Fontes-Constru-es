using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Ecommerce.Domain.Entities;


namespace Application.Interfaces.Validacao
{
    public class TagValidator : AbstractValidator<TagDto>
    {
        public TagValidator()
        {
            RuleFor(tag => tag.Nome)
                .NotEmpty().WithMessage(TagMessages.NomeObrigatorio)
                .MaximumLength(50).WithMessage(TagMessages.NomeMax50);

            RuleFor(tag => tag.Produtos)
                .NotEmpty().WithMessage(TagMessages.ProdutosObrigatorio);
        }
    }
}
