using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Dtos;
public class ClienteDto
{
    public required string UserName { get; set; }
    public required string Telefone { get; set; }
    public required string Endereco { get; set; }
    public required string Cidade { get; set; }
    public required string Estado { get; set; }
    public required string Cep { get; set; }
    public required string Pais { get; set; }
}