using FluentValidation;
using Application.Dtos;
using Resources;

namespace Application.Interfaces.Validacao
{
    public class DescontoValidator : AbstractValidator<DescontoDto>
    {
        public DescontoValidator()
        {
            RuleFor(x => x.Valor)
                .GreaterThan(0)
                .WithMessage(MessagesHelper.ValorDeveSerMaiorQueZero);
                

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(MessagesHelper.DescricaoObrigatoria);
                
        }
    }
}
