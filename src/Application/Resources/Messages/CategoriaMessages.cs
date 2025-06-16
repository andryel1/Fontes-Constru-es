using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class CategoriaMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.CategoriaMessages", typeof(CategoriaMessages).Assembly);

    public static string NomeObrigatorio =>
        resourceManager.GetString("NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";

    public static string NomeMax100 =>
        resourceManager.GetString("NomeMax100", CultureInfo.CurrentUICulture) ?? "[NomeMax100]";

    public static string ProdutosObrigatorio =>
        resourceManager.GetString("ProdutosObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutosObrigatorio]";

    public static string ProdutosMin1 =>
        resourceManager.GetString("ProdutosMin1", CultureInfo.CurrentUICulture) ?? "[ProdutosMin1]";
} 