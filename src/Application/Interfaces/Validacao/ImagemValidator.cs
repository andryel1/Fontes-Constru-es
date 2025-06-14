using FluentValidation;
using Application.Dtos;
using Resources.Messages;

public class ImagemValidator : AbstractValidator<ImagemDto>
{
    public ImagemValidator()
    {
        RuleFor(x => x.Url)
            .NotEmpty().WithMessage(ImagemMessages.UrlObrigatoria)
            .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute))
            .WithMessage(ImagemMessages.UrlInvalida);

        RuleFor(x => x.ProdutoId)
            .NotEmpty().WithMessage(ImagemMessages.ProdutoIdObrigatorio);
    }
}