using Application.Dtos;
using FluentValidation;
using Microsoft.Extensions.Localization;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

public class AvaliacaoValidator : AbstractValidator<AvaliacaoDto>
{
    public AvaliacaoValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);
        RuleFor(x => x.Nota)
            .NotNull().WithMessage(localizer[AvaliacaoMessages.NotaObrigatoria])
            .InclusiveBetween(1, 5).WithMessage(localizer[AvaliacaoMessages.NotaEntre1E5]);

        RuleFor(x => x.Comentario)
            .NotEmpty().WithMessage(AvaliacaoMessages.ComentarioObrigatorio)
            .MaximumLength(500).WithMessage(localizer[AvaliacaoMessages.ComentarioMax500]);

        RuleFor(x => x.Data)
            .NotNull().WithMessage(localizer[AvaliacaoMessages.DataObrigatoria]);
    }
}
