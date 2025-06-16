using FluentValidation;
using Application.Dtos;

namespace Application.Interfaces.Validacao
{
    public class TagValidator : AbstractValidator<TagDto>
    {
        public TagValidator()
        {
        
        }
    }
}
