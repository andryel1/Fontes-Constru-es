using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations;
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.ToTable("Pedido");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Status)
               .HasMaxLength(50)
               .HasColumnType("varchar(50)");

        builder.Property(p => p.ValorTotal)
               .HasColumnType("decimal(10,2)");

        builder.Property(p => p.DataPedido).IsRequired();
        builder.Property(p => p.DataEnvio);
        builder.Property(p => p.DataEntrega);

        builder.HasMany(p => p.Itens)
        .WithOne(p => p.Pedido)
        .HasForeignKey(p => p.PedidoId);

        builder.HasMany(p => p.Pagamentos)
        .WithMany(p => p.Pedidos);

    }
}

