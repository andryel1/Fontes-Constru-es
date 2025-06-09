public static class ProdutoMessages
{
    private static readonly ResourceManager resourceManager = 
        new("Resources.Messages", typeof(ProdutoMessages).Assembly);

    public static string NomeObrigatorio =>
        resourceManager.GetString("Produto_NomeObrigatorio", CultureInfo.CurrentUICulture) ?? "[NomeObrigatorio]";

    public static string DescricaoMax200 =>
        resourceManager.GetString("Produto_DescricaoMax200", CultureInfo.CurrentUICulture) ?? "[DescricaoMax200]";
}
