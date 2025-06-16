using Ecommerce.Domain.Entities;

namespace Application.Dtos
{
    public record InformacoesEnvioDto(
        required string Endereço,
        required string Cidade,
        required string Estado,
        required string Cep,
        required int Numero,
        required string Complemento,
        required string Telefone,
        required string NomeDestinatario,
        required string SobrenomeDestinatario,
        required string CpfDestinatario,
        required string EmailDestinatario,
        required Produto Produto,
        required int ProdutoId,
        required DateTime DatetimeEnvio,
        required DateTime DataDeEnvioPrevista
    );
}