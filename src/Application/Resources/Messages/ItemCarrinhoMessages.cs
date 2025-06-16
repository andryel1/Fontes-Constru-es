using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class ItemCarrinhoMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.ItemCarrinhoMessages", typeof(ItemCarrinhoMessages).Assembly);

    public static string QuantidadeObrigatoria =>
        resourceManager.GetString("QuantidadeObrigatoria", CultureInfo.CurrentUICulture) ?? "[QuantidadeObrigatoria]";

    public static string QuantidadeMaiorQueZero =>
        resourceManager.GetString("QuantidadeMaiorQueZero", CultureInfo.CurrentUICulture) ?? "[QuantidadeMaiorQueZero]";

    public static string PrecoObrigatorio =>
        resourceManager.GetString("PrecoObrigatorio", CultureInfo.CurrentUICulture) ?? "[PrecoObrigatorio]";

    public static string PrecoMaiorQueZero =>
        resourceManager.GetString("PrecoMaiorQueZero", CultureInfo.CurrentUICulture) ?? "[PrecoMaiorQueZero]";

    public static string ProdutoObrigatorio =>
        resourceManager.GetString("ProdutoObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutoObrigatorio]";

    public static string CarrinhoObrigatorio =>
        resourceManager.GetString("CarrinhoObrigatorio", CultureInfo.CurrentUICulture) ?? "[CarrinhoObrigatorio]";

    public static string CarrinhoIdObrigatorio =>
        resourceManager.GetString("CarrinhoIdObrigatorio", CultureInfo.CurrentUICulture) ?? "[CarrinhoIdObrigatorio]";

    public static string ProdutoIdObrigatorio =>
        resourceManager.GetString("ProdutoIdObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutoIdObrigatorio]";
} 