using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class DetalhePedidoMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.DetalhePedidoMessages", typeof(DetalhePedidoMessages).Assembly);

    public static string NomeObrigatorio =>
        resourceManager.GetString("NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";

    public static string NomeMax100 =>
        resourceManager.GetString("NomeMax100", CultureInfo.CurrentUICulture) ?? "[NomeMax100]";

    public static string ProdutosObrigatorio =>
        resourceManager.GetString("ProdutosObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutosObrigatorio]";

    public static string ProdutosMin1 =>
        resourceManager.GetString("ProdutosMin1", CultureInfo.CurrentUICulture) ?? "[ProdutosMin1]";

    public static string PedidoIdObrigatorio =>
        resourceManager.GetString("PedidoIdObrigatorio", CultureInfo.CurrentUICulture) ?? "[PedidoIdObrigatorio]";

    public static string PedidoIdInvalido =>
        resourceManager.GetString("PedidoIdInvalido", CultureInfo.CurrentUICulture) ?? "[PedidoIdInvalido]";

    public static string ProdutoIdObrigatorio =>
        resourceManager.GetString("ProdutoIdObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutoIdObrigatorio]";

    public static string ProdutoIdInvalido =>
        resourceManager.GetString("ProdutoIdInvalido", CultureInfo.CurrentUICulture) ?? "[ProdutoIdInvalido]";

    public static string QuantidadeObrigatoria =>
        resourceManager.GetString("QuantidadeObrigatoria", CultureInfo.CurrentUICulture) ?? "[QuantidadeObrigatoria]";

    public static string QuantidadeInvalida =>
        resourceManager.GetString("QuantidadeInvalida", CultureInfo.CurrentUICulture) ?? "[QuantidadeInvalida]";

    public static string PrecoObrigatorio =>
        resourceManager.GetString("PrecoObrigatorio", CultureInfo.CurrentUICulture) ?? "[PrecoObrigatorio]";

    public static string PrecoInvalido =>
        resourceManager.GetString("PrecoInvalido", CultureInfo.CurrentUICulture) ?? "[PrecoInvalido]";

    public static string DetalheNaoEncontrado =>
        resourceManager.GetString("DetalheNaoEncontrado", CultureInfo.CurrentUICulture) ?? "[DetalheNaoEncontrado]";
}