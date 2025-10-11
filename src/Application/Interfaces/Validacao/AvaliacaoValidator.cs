using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;

    public class AvaliacaoValidator : AbstractValidator<AvaliacaoDto>
    {
            public AvaliacaoValidator()
        {
            RuleFor(x => x.Nota)
                .NotNull()
                .NotEmpty()
                .WithMessage(AvaliacaoMessages.NotaObrigatoria)
                .InclusiveBetween(1, 5)
                .WithMessage(AvaliacaoMessages.NotaEntre1E5);

            RuleFor(x => x.Comentario)
                .NotEmpty()
                .NotNull()
                .WithMessage(AvaliacaoMessages.ComentarioObrigatorio)
                .MaximumLength(500)
                .WithMessage(AvaliacaoMessages.ComentarioMax500);

            RuleFor(x => x.Data)
                .NotNull()
                .NotEmpty()
                .WithMessage(AvaliacaoMessages.DataObrigatoria);

            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty();
        }
    }
