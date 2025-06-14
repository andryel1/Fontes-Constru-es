using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class TagMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.TagMessages", typeof(TagMessages).Assembly);

    public static string NomeObrigatorio =>
        resourceManager.GetString("NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";

    public static string NomeMax50 =>
        resourceManager.GetString("NomeMax50", CultureInfo.CurrentUICulture) ?? "[NomeMax50]";

    public static string ProdutosObrigatorio =>
        resourceManager.GetString("ProdutosObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutosObrigatorio]";

    public static string ProdutosMin1 =>
        resourceManager.GetString("ProdutosMin1", CultureInfo.CurrentUICulture) ?? "[ProdutosMin1]";
} 