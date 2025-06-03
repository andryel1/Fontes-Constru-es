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
                .WithMessage(MessagesHelper.ValorDeveSerMaiorQueZero)
                .NotEmpty()
                .NotNull()
                .WithMessage(MessagesHelper.IdObrigatorio);

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(MessagesHelper.DescricaoObrigatoria);
            RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage(MessagesHelper.DescricaoMax200);            
           
        }
    }
}
