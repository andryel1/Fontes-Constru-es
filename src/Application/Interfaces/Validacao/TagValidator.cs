using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Ecommerce.Domain.Entities;
using Microsoft.Extensions.Localization;


namespace Application.Interfaces.Validacao
{
    public class TagValidator : AbstractValidator<TagDto>
    {
        public TagValidator(IStringLocalizer localizer)
        {
            ArgumentNullException.ThrowIfNull(localizer);
        }
    }
}
