using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao
{
    public class TagValidator : AbstractValidator<TagDto>
    {
        public TagValidator()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage(TagMessages.NomeObrigatorio);

            RuleFor(x => x.Produtos)
                .NotNull()
                .WithMessage(TagMessages.TagNaoEncontrada);

            RuleFor(x => x.Id);
        }
    }
}