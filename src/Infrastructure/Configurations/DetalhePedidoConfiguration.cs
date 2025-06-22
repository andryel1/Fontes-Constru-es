using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations;

public class DetalhePedidoConfiguration : IEntityTypeConfiguration<DetalhePedido>
{
    public void Configure(EntityTypeBuilder<DetalhePedido> builder)
    {
        builder.ToTable("DetalhePedido");

        builder.Property(d => d.NomeProduto);

        builder.Property(d => d.Preco)
        .HasColumnType("decimal(10,2)");
    }
}