using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations
{
    public class ProdutoConfiguration :IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(500);

            builder.Property(p => p.Descricao)
            .IsRequired()
            .HasMaxLength(500);

            builder.Property(p => p.Estoque)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.Preco)
            .IsRequired()
            .HasColumnType("decimal(10, 2)");

            builder.HasMany(p => p.Imagens)
            .WithOne(i => i.Produto)
            .HasForeignKey(i => i.ProdutoId);

            builder.HasMany(p => p.Avaliacoes)
            .WithOne(a => a.Produto)
            .HasForeignKey(a => a.ProdutoId);

            builder.HasMany(p => p.ItensCarrinho)
            .WithOne(i => i.Produto)
            .HasForeignKey(i => i.ProdutoId);

            builder.HasMany(p => p.Pedidos)
            .WithOne(p => p.Produto)
            .HasForeignKey(i => i.ProdutoId);

            builder.HasMany(p => p.ListaDesejos)
            .WithMany(l => l.Produtos);

            builder.HasMany(p => p.Categorias)
            .WithMany(c => c.Produtos);

            builder.HasMany(p => p.Tags)
            .WithOne(t => t.Produto)
            .HasForeignKey(t => t.ProdutoId);
        }
    }
}