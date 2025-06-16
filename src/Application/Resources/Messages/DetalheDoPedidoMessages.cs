using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class DetalheDoPedidoMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.DetalheDoPedidoMessages", typeof(DetalheDoPedidoMessages).Assembly);

    public static string UrlObrigatoria =>
        resourceManager.GetString("UrlObrigatoria", CultureInfo.CurrentUICulture) ?? "[UrlObrigatoria]";

    public static string UrlInvalida =>
        resourceManager.GetString("UrlInvalida", CultureInfo.CurrentUICulture) ?? "[UrlInvalida]";

    public static string ProdutoIdObrigatorio =>
        resourceManager.GetString("ProdutoIdObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutoIdObrigatorio]";

    public static string ProdutoIdInvalido =>
        resourceManager.GetString("ProdutoIdInvalido", CultureInfo.CurrentUICulture) ?? "[ProdutoIdInvalido]";
}