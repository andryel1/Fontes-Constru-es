using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class DescontoMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.DescontoMessages", typeof(DescontoMessages).Assembly);

    public static string NomeObrigatorio =>
        resourceManager.GetString("NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";

    public static string NomeMax100 =>
        resourceManager.GetString("NomeMax100", CultureInfo.CurrentUICulture) ?? "[NomeMax100]";

    public static string ValorObrigatorio =>
        resourceManager.GetString("ValorObrigatorio", CultureInfo.CurrentUICulture) ?? "[ValorObrigatorio]";

    public static string ValorMaiorQueZero =>
        resourceManager.GetString("ValorMaiorQueZero", CultureInfo.CurrentUICulture) ?? "[ValorMaiorQueZero]";

    public static string DataInicioObrigatoria =>
        resourceManager.GetString("DataInicioObrigatoria", CultureInfo.CurrentUICulture) ?? "[DataInicioObrigatoria]";

    public static string DataFimObrigatoria =>
        resourceManager.GetString("DataFimObrigatoria", CultureInfo.CurrentUICulture) ?? "[DataFimObrigatoria]";

    public static string DataFimMaiorQueInicio =>
        resourceManager.GetString("DataFimMaiorQueInicio", CultureInfo.CurrentUICulture) ?? "[DataFimMaiorQueInicio]";

    public static string ProdutosObrigatorio =>
        resourceManager.GetString("ProdutosObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutosObrigatorio]";

    public static string ProdutosMin1 =>
        resourceManager.GetString("ProdutosMin1", CultureInfo.CurrentUICulture) ?? "[ProdutosMin1]";
        
    public static string AtivoObrigatorio =>
    resourceManager.GetString("AtivoObrigatorio", CultureInfo.CurrentUICulture) ?? "[AtivoObrigatorio]";

    public static string IdObrigatorio =>
    resourceManager.GetString("IdObrigatorio", CultureInfo.CurrentUICulture) ?? "[IdObrigatorio]";

    public static string ProdutoIdObrigatorio =>
    resourceManager.GetString("ProdutoIdObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutoIdObrigatorio]";

} 