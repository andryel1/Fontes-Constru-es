using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Descricao)
                .HasMaxLength(1000);

            builder.Property(p => p.Estoque)
                .HasMaxLength(50);

            builder.Property(p => p.Preco)
                .HasColumnType("decimal(18,2)");

            builder.HasMany(p => p.Imagens)
                .WithOne(i => i.Produto)
                .HasForeignKey(i => i.ProdutoId);

            builder.HasMany(p => p.Avaliacoes)
                .WithOne(a => a.Produto)
                .HasForeignKey(a => a.ProdutoId);

            builder.HasMany(p => p.ItensCarrinho)
                .WithOne(ic => ic.Produto)
                .HasForeignKey(ic => ic.ProdutoId);

            builder.HasMany(p => p.Pedidos)
                .WithMany(ped => ped.Produtos);

            builder.HasMany(p => p.ListaDesejos)
                .WithMany(ld => ld.Produtos);

            builder.HasMany(p => p.Categorias)
                .WithMany(c => c.Produtos);

            builder.HasMany(p => p.Tags)
                .WithMany(t => t.Produtos);
        }
    }
}