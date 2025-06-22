using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations
{
    public class CarrinhoConfiguration : IEntityTypeConfiguration<Carrinho>
    {
        public void Configure(EntityTypeBuilder<Carrinho> builder)
        {
            builder.ToTable("Carrinhos");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCriacao)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(c => c.PrecoTotal)
                .IsRequired()
                .HasColumnType("decimal(10, 2)");

            builder.HasOne(c => c.Cliente)
                .WithMany()
                .HasForeignKey(c => c.ClienteId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Pedido)
                .WithMany(p => p.Itens)
                .HasForeignKey(c => c.PedidoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Itens)
                .WithOne(i => i.Carrinho)
                .HasForeignKey(i => i.CarrinhoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 