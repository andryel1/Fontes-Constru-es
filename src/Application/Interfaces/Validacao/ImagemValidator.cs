using FluentValidation;
using Application.Dtos;
using Resources.Messages;

namespace Application.Interfaces.Validacao;
public class ImagemValidator : AbstractValidator<ImagemDto>
{
    public ImagemValidator()
    {
        RuleFor(x => x.Url)
            .NotEmpty().WithMessage(ImagemMessages.UrlObrigatoria)
            .Must(url => url != null && Uri.IsWellFormedUriString(url.AbsoluteUri, UriKind.Absolute))
            .WithMessage(ImagemMessages.UrlInvalida);

        RuleFor(x => x.ProdutoId)
            .NotEmpty().WithMessage(ImagemMessages.ProdutoIdObrigatorio);
    }
}