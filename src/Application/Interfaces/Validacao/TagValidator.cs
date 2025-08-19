using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Ecommerce.Domain.Entities;
using Microsoft.Extensions.Localization;
using Org.BouncyCastle.Math.EC.Rfc7748;


namespace Application.Interfaces.Validacao
{
    public class TagValidator : AbstractValidator<TagDto>
    {
        public TagValidator(IStringLocalizer<TagDto> localizer)
        {
            ArgumentNullException.ThrowIfNull(localizer);

            RuleFor(x => x.Nome)
            .NotNull()
            .NotEmpty()
            .WithMessage(localizer[TagMessages.NomeObrigatorio]);
        }
    }
}
