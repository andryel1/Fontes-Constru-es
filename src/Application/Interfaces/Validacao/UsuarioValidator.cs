using Resources.Messages;
using Application.Dtos;
using FluentValidation;

namespace Application.Interfaces.Validacao;
public class UsuarioValidator : AbstractValidator<AvaliacaoDto>
{
    public UsuarioValidator()
    {
        
    }
}