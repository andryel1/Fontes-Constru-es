using FluentValidation;
using Application.Dtos;
using Resources.Messages;
using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Validacao;
public class ImagemValidator : AbstractValidator<ImagemDto>
{
    public ImagemValidator(IStringLocalizer localizer)
    {
        ArgumentNullException.ThrowIfNull(localizer);

        RuleFor(x => x.Id);

        RuleFor(x => x.Url)
            .NotEmpty().WithMessage(localizer[ImagemMessages.UrlObrigatoria])
            .Must((_, url) => url != null && Uri.IsWellFormedUriString(url.AbsoluteUri, UriKind.Absolute))
            .WithMessage(localizer[ImagemMessages.UrlInvalida]);

        RuleFor(x => x.ProdutoId)
            .NotEmpty().WithMessage(localizer[ImagemMessages.ProdutoIdObrigatorio])
            .GreaterThan(0).WithMessage(localizer[ImagemMessages.ProdutoIdInvalido]);

        RuleFor(x => x.Produto);
    }
}