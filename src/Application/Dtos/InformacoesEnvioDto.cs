using Ecommerce.Domain.Entities;

namespace Application.Dtos
{
    public record InformacoesEnvioDto(
        string Endereco,
        string Cidade,
        string Estado,
        string Cep,
        int Numero,
        string Complemento,
        string Telefone,
        string NomeDestinatario,
        string SobrenomeDestinatario,
        string CpfDestinatario,
        string EmailDestinatario,
        Produto Produto,
        int ProdutoId,
        DateTime DatetimeEnvio,
        DateTime DataDeEnvioPrevista
    );
}