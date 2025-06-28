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
        }
    }
}