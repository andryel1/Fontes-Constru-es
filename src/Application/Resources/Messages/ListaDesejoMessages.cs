using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class ListaDesejoMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.ListaDesejoMessages", typeof(ListaDesejoMessages).Assembly);

    public static string DataAdicaoObrigatoria =>
        resourceManager.GetString("DataAdicaoObrigatoria", CultureInfo.CurrentUICulture) ?? "[DataAdicaoObrigatoria]";

    public static string DataAdicaoInvalida =>
        resourceManager.GetString("DataAdicaoInvalida", CultureInfo.CurrentUICulture) ?? "[DataAdicaoInvalida]";

    public static string ProdutosObrigatorio =>
        resourceManager.GetString("ProdutosObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutosObrigatorio]";

    public static string ProdutosMin1 =>
        resourceManager.GetString("ProdutosMin1", CultureInfo.CurrentUICulture) ?? "[ProdutosMin1]";

    public static string ClienteObrigatorio =>
        resourceManager.GetString("ClienteObrigatorio", CultureInfo.CurrentUICulture) ?? "[ClienteObrigatorio]";
} 