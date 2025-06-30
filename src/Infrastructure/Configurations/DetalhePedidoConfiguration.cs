using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations;

public class DetalhePedidoConfiguration : IEntityTypeConfiguration<DetalhePedido>
{
    public void Configure(EntityTypeBuilder<DetalhePedido> builder)
    {
        builder.ToTable("DetalhePedido");

        builder.Property(d => d.NomeProduto)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.Quantidade)
            .IsRequired();

        builder.Property(d => d.Preco)
            .HasColumnType("decimal(18,2)")
            .IsRequired();


    }
}