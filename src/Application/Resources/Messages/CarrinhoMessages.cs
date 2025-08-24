using System.Globalization;
using System.Resources;

namespace Resources.Messages
{
    public static class CarrinhoMessages
    {
        private static readonly ResourceManager resourceManager =
            new("Resources.Messages.CarrinhoMessages", typeof(CarrinhoMessages).Assembly);

        public static string NomeObrigatorio =>
            resourceManager.GetString("NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";

        public static string ItemInvalido =>
            resourceManager.GetString("ItemInvalido", CultureInfo.CurrentUICulture) ?? "[ItemInvalido]";

        public static string ModificacaoNaoPermitida =>
            resourceManager.GetString("ModificacaoNaoPermitida", CultureInfo.CurrentUICulture) ?? "[ModificacaoNaoPermitida]";

        public static string ItemAdicionadoComSucesso =>
            resourceManager.GetString("ItemAdicionadoComSucesso", CultureInfo.CurrentUICulture) ?? "[ItemAdicionadoComSucesso]";

        public static string ItemRemovidoComSucesso =>
            resourceManager.GetString("ItemRemovidoComSucesso", CultureInfo.CurrentUICulture) ?? "[ItemRemovidoComSucesso]";
    }
}
