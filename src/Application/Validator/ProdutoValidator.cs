using FluentValidation;
using Microsoft.Extensions.Localization;
using Resources.Messages;
using Ecommerce.Domain.Entities;

namespace Application.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {

        public ProdutoValidator(IStringLocalizerFactory localizerFactory)
        {
            ArgumentNullException.ThrowIfNull(localizerFactory);
            var localizer = localizerFactory.Create(typeof(ProdutoMessages));
          
        }
    }
}


