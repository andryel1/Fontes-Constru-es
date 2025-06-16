using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class ProdutoMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.ProdutoMessages", typeof(ProdutoMessages).Assembly);

    public static string NomeObrigatorio =>
        resourceManager.GetString("NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";

    public static string NomeMax200 =>
        resourceManager.GetString("NomeMax200", CultureInfo.CurrentUICulture) ?? "[NomeMax200]";

    public static string DescricaoObrigatoria =>
        resourceManager.GetString("DescricaoObrigatoria", CultureInfo.CurrentUICulture) ?? "[DescricaoObrigatoria]";

    public static string DescricaoMax500 =>
        resourceManager.GetString("DescricaoMax500", CultureInfo.CurrentUICulture) ?? "[DescricaoMax500]";

    public static string EstoqueObrigatorio =>
        resourceManager.GetString("EstoqueObrigatorio", CultureInfo.CurrentUICulture) ?? "[EstoqueObrigatorio]";

    public static string PrecoObrigatorio =>
        resourceManager.GetString("PrecoObrigatorio", CultureInfo.CurrentUICulture) ?? "[PrecoObrigatorio]";

    public static string PrecoMaiorQueZero =>
        resourceManager.GetString("PrecoMaiorQueZero", CultureInfo.CurrentUICulture) ?? "[PrecoMaiorQueZero]";

    public static string ImagensObrigatorio =>
        resourceManager.GetString("ImagensObrigatorio", CultureInfo.CurrentUICulture) ?? "[ImagensObrigatorio]";

    public static string CategoriasObrigatorio =>
        resourceManager.GetString("CategoriasObrigatorio", CultureInfo.CurrentUICulture) ?? "[CategoriasObrigatorio]";
} 