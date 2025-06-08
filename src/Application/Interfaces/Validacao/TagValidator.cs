using FluentValidation;
using Application.Dtos;
using Resources;

namespace Application.Interfaces.Validacao
{
    public class TagValidator : AbstractValidator<TagDto>
    {
        public TagValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage(MessagesHelper.ValorDeveSerMaiorQueZero);

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(MessagesHelper.DescricaoObrigatoria)
                .MaximumLength(200)
                .WithMessage(MessagesHelper.DescricaoMax200);

            RuleFor(x => x.Produtos)
                .NotNull()
                .WithMessage(MessagesHelper.ValorDeveSerMaiorQueZero);
        }
    }
}
