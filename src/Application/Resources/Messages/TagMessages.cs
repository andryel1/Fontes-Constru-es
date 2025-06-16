using System.Globalization;
using System.Resources;

namespace Resources.Messages;

public static class TagMessages
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages.TagMessages", typeof(TagMessages).Assembly);

    public static string NomeObrigatorio =>
        resourceManager.GetString("NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";
    public static string NomeInvalido =>
        resourceManager.GetString("NomeInvalido", CultureInfo.CurrentUICulture) ?? "[NomeInvalido]";

    public static string TagJaExiste =>
        resourceManager.GetString("TagJaExiste", CultureInfo.CurrentUICulture) ?? "[TagJaExiste]";

    public static string TagNaoEncontrada =>
        resourceManager.GetString("TagNaoEncontrada", CultureInfo.CurrentUICulture) ?? "[TagNaoEncontrada]";
}