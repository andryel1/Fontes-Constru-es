using Resources.Messages;
using Application.Dtos;
using FluentValidation;

namespace Application.Interfaces.Validacao;
public class UsuarioValidator : AbstractValidator<AvaliacaoDto>
{
    public UsuarioValidator()
    {

        RuleFor(x => x.Comentario)
        .NotNull();

        RuleFor(x => x.Data)
        .NotNull();
        
    }
}