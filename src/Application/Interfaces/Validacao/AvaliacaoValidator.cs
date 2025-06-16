using Application.Dtos;
using FluentValidation;
using Resources.Messages;

public class AvaliacaoValidator : AbstractValidator<AvaliacaoDto>
{
    public AvaliacaoValidator()
    {
        RuleFor(x => x.Nota)
            .NotNull().WithMessage(AvaliacaoMessages.NotaObrigatoria)
            .InclusiveBetween(1, 5).WithMessage(AvaliacaoMessages.NotaEntre1E5);

        RuleFor(x => x.Comentario)
            .NotEmpty().WithMessage(AvaliacaoMessages.ComentarioObrigatorio)
            .MaximumLength(500).WithMessage(AvaliacaoMessages.ComentarioMax500);

        RuleFor(x => x.Data)
            .NotNull().WithMessage(AvaliacaoMessages.DataObrigatoria);
    }
}