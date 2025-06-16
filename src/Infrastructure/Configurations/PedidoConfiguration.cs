using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido> 
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataPedido)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.Status)
                .IsRequired()   
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.ValorTotal)
                .IsRequired()
                .HasColumnType("decimal(10, 2)");

            builder.Property(p => p.DataEnvio)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Property(p => p.DataEntrega)
                .HasColumnType("datetime")
                .IsRequired(false);
                
            builder.HasMany(p => p.Itens)
                .WithOne(i => i.Pedido)
                .HasForeignKey(i => i.PedidoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Clientes)
                .WithMany()
                .UsingEntity(j => j.ToTable("PedidoCliente"));

            builder.HasMany(p => p.Pagamentos)
                .WithOne(p => p.Pedido)
                .HasForeignKey(p => p.PedidoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.InformacoesEnvio)
                .WithOne()
                .HasForeignKey("PedidoId")
                .OnDelete(DeleteBehavior.Restrict);
        }   
    }   
}   