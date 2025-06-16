using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class ClienteMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.ClienteMessages", typeof(ClienteMessages).Assembly);

    public static string NomeObrigatorio =>
        resourceManager.GetString("NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";

    public static string NomeMax200 =>
        resourceManager.GetString("NomeMax200", CultureInfo.CurrentUICulture) ?? "[NomeMax200]";

    public static string CpfObrigatorio =>
        resourceManager.GetString("CpfObrigatorio", CultureInfo.CurrentUICulture) ?? "[CpfObrigatorio]";

    public static string CpfInvalido =>
        resourceManager.GetString("CpfInvalido", CultureInfo.CurrentUICulture) ?? "[CpfInvalido]";

    public static string SenhaObrigatoria =>
        resourceManager.GetString("SenhaObrigatoria", CultureInfo.CurrentUICulture) ?? "[SenhaObrigatoria]";

    public static string SenhaMin8 =>
        resourceManager.GetString("SenhaMin8", CultureInfo.CurrentUICulture) ?? "[SenhaMin8]";

    public static string TelefoneObrigatorio =>
        resourceManager.GetString("TelefoneObrigatorio", CultureInfo.CurrentUICulture) ?? "[TelefoneObrigatorio]";

    public static string TelefoneInvalido =>
        resourceManager.GetString("TelefoneInvalido", CultureInfo.CurrentUICulture) ?? "[TelefoneInvalido]";

    public static string EmailObrigatorio =>
        resourceManager.GetString("EmailObrigatorio", CultureInfo.CurrentUICulture) ?? "[EmailObrigatorio]";

    public static string EmailInvalido =>
        resourceManager.GetString("EmailInvalido", CultureInfo.CurrentUICulture) ?? "[EmailInvalido]";

    public static string DataNascimentoObrigatoria =>
        resourceManager.GetString("DataNascimentoObrigatoria", CultureInfo.CurrentUICulture) ?? "[DataNascimentoObrigatoria]";

    public static string DataNascimentoInvalida =>
        resourceManager.GetString("DataNascimentoInvalida", CultureInfo.CurrentUICulture) ?? "[DataNascimentoInvalida]";
} 