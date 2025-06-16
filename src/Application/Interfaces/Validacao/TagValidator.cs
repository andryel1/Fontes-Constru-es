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
        }
    }
}
