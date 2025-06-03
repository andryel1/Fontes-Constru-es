using System.Globalization;
using System.Resources;

namespace Resources;

public static class MessagesHelper
{
    private static readonly ResourceManager resourceManager =
        new("Resources.Messages", typeof(MessagesHelper).Assembly);

    public static string ValorDeveSerMaiorQueZero =>
    resourceManager.GetString("ValorDeveSerMaiorQueZero", CultureInfo.CurrentUICulture) ?? "[ValorDeveSerMaiorQueZero]";

    public static string DescricaoObrigatoria =>
        resourceManager.GetString("DescricaoObrigatoria", CultureInfo.CurrentUICulture) ?? "[DescricaoObrigatoria]";

    public static string DescricaoMax200 =>
     resourceManager.GetString("DescricaoMax200", CultureInfo.CurrentUICulture) ?? "[DescricaoMax200]";
     public static string IdObrigatorio =>
     resourceManager.GetString("IdObrigatorio", CultureInfo.CurrentUICulture) ?? "[IdObrigatorio]";
}