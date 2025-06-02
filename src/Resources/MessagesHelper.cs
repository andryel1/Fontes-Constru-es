using System.Globalization;
using System.Resources;

namespace Resources;

public static class MessagesHelper
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages", typeof(MessagesHelper).Assembly);

    public static string Hello => resourceManager.GetString("Hello", CultureInfo.CurrentUICulture) ?? "[Hello]";
    public static string Bye => resourceManager.GetString("Bye", CultureInfo.CurrentUICulture) ?? "[Bye]";
}
