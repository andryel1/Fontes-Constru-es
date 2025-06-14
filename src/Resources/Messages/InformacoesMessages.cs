using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class InformacoesMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.InformacoesMessages", typeof(InformacoesMessages).Assembly);

    public static string EnderecoObrigatorio =>
        resourceManager.GetString("EnderecoObrigatorio", CultureInfo.CurrentUICulture) ?? "[EnderecoObrigatorio]";

    public static string CidadeObrigatoria =>
        resourceManager.GetString("CidadeObrigatoria", CultureInfo.CurrentUICulture) ?? "[CidadeObrigatoria]";

    public static string EstadoObrigatorio =>
        resourceManager.GetString("EstadoObrigatorio", CultureInfo.CurrentUICulture) ?? "[EstadoObrigatorio]";

    public static string CepObrigatorio =>
        resourceManager.GetString("CepObrigatorio", CultureInfo.CurrentUICulture) ?? "[CepObrigatorio]";

    public static string CepInvalido =>
        resourceManager.GetString("CepInvalido", CultureInfo.CurrentUICulture) ?? "[CepInvalido]";

    public static string NumeroObrigatorio =>
        resourceManager.GetString("NumeroObrigatorio", CultureInfo.CurrentUICulture) ?? "[NumeroObrigatorio]";

    public static string ComplementoObrigatorio =>
        resourceManager.GetString("ComplementoObrigatorio", CultureInfo.CurrentUICulture) ?? "[ComplementoObrigatorio]";

    public static string TelefoneObrigatorio =>
        resourceManager.GetString("TelefoneObrigatorio", CultureInfo.CurrentUICulture) ?? "[TelefoneObrigatorio]";

    public static string TelefoneInvalido =>
        resourceManager.GetString("TelefoneInvalido", CultureInfo.CurrentUICulture) ?? "[TelefoneInvalido]";

    public static string NomeDestinatarioObrigatorio =>
        resourceManager.GetString("NomeDestinatarioObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeDestinatarioObrigatorio]";

    public static string SobrenomeDestinatarioObrigatorio =>
        resourceManager.GetString("SobrenomeDestinatarioObrigatorio", CultureInfo.CurrentUICulture) ?? "[SobrenomeDestinatarioObrigatorio]";

    public static string CpfDestinatarioObrigatorio =>
        resourceManager.GetString("CpfDestinatarioObrigatorio", CultureInfo.CurrentUICulture) ?? "[CpfDestinatarioObrigatorio]";

    public static string CpfDestinatarioInvalido =>
        resourceManager.GetString("CpfDestinatarioInvalido", CultureInfo.CurrentUICulture) ?? "[CpfDestinatarioInvalido]";

    public static string EmailDestinatarioObrigatorio =>
        resourceManager.GetString("EmailDestinatarioObrigatorio", CultureInfo.CurrentUICulture) ?? "[EmailDestinatarioObrigatorio]";

    public static string EmailDestinatarioInvalido =>
        resourceManager.GetString("EmailDestinatarioInvalido", CultureInfo.CurrentUICulture) ?? "[EmailDestinatarioInvalido]";

    public static string ProdutoObrigatorio =>
        resourceManager.GetString("ProdutoObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutoObrigatorio]";

    public static string ProdutoIdObrigatorio =>
        resourceManager.GetString("ProdutoIdObrigatorio", CultureInfo.CurrentUICulture) ?? "[ProdutoIdObrigatorio]";

    public static string DataEnvioObrigatoria =>
        resourceManager.GetString("DataEnvioObrigatoria", CultureInfo.CurrentUICulture) ?? "[DataEnvioObrigatoria]";

    public static string DataEnvioPrevistaObrigatoria =>
        resourceManager.GetString("DataEnvioPrevistaObrigatoria", CultureInfo.CurrentUICulture) ?? "[DataEnvioPrevistaObrigatoria]";
} 