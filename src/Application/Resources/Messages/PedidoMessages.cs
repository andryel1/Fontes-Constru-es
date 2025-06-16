using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class PedidoMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.PedidoMessages", typeof(PedidoMessages).Assembly);

    public static string ValorObrigatorio =>
        resourceManager.GetString("ValorObrigatorio", CultureInfo.CurrentUICulture) ?? "[ValorObrigatorio]";

    public static string ValorMaiorQueZero =>
        resourceManager.GetString("ValorMaiorQueZero", CultureInfo.CurrentUICulture) ?? "[ValorMaiorQueZero]";

    public static string TipoPagamentoObrigatorio =>
        resourceManager.GetString("TipoPagamentoObrigatorio", CultureInfo.CurrentUICulture) ?? "[TipoPagamentoObrigatorio]";

    public static string TipoPagamentoInvalido =>
        resourceManager.GetString("TipoPagamentoInvalido", CultureInfo.CurrentUICulture) ?? "[TipoPagamentoInvalido]";

    public static string StatusObrigatorio =>
        resourceManager.GetString("StatusObrigatorio", CultureInfo.CurrentUICulture) ?? "[StatusObrigatorio]";

    public static string StatusInvalido =>
        resourceManager.GetString("StatusInvalido", CultureInfo.CurrentUICulture) ?? "[StatusInvalido]";

    public static string DataPagamentoObrigatoria =>
        resourceManager.GetString("DataPagamentoObrigatoria", CultureInfo.CurrentUICulture) ?? "[DataPagamentoObrigatoria]";

    public static string DataPagamentoInvalida =>
        resourceManager.GetString("DataPagamentoInvalida", CultureInfo.CurrentUICulture) ?? "[DataPagamentoInvalida]";

    public static string ParcelamentoIdObrigatorio =>
        resourceManager.GetString("ParcelamentoIdObrigatorio", CultureInfo.CurrentUICulture) ?? "[ParcelamentoIdObrigatorio]";

    public static string PedidosObrigatorio =>
        resourceManager.GetString("PedidosObrigatorio", CultureInfo.CurrentUICulture) ?? "[PedidosObrigatorio]";
} 