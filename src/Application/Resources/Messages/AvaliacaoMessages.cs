using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class AvaliacaoMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.AvaliacaoMessages", typeof(AvaliacaoMessages).Assembly);

    public static string NotaObrigatoria =>
        resourceManager.GetString("NotaObrigatoria", CultureInfo.CurrentUICulture) ?? "[NotaObrigatoria]";

    public static string NotaEntre1E5 =>
        resourceManager.GetString("NotaEntre1E5", CultureInfo.CurrentUICulture) ?? "[NotaEntre1E5]";

    public static string ComentarioObrigatorio =>
        resourceManager.GetString("ComentarioObrigatorio", CultureInfo.CurrentUICulture) ?? "[ComentarioObrigatorio]";

    public static string ComentarioMax500 =>
        resourceManager.GetString("ComentarioMax500", CultureInfo.CurrentUICulture) ?? "[ComentarioMax500]";

    public static string DataObrigatoria =>
        resourceManager.GetString("DataObrigatoria", CultureInfo.CurrentUICulture) ?? "[DataObrigatoria]";

    public static string DataInvalida =>
        resourceManager.GetString("DataInvalida", CultureInfo.CurrentUICulture) ?? "[DataInvalida]";
} 