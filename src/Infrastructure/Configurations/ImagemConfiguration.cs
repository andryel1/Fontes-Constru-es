using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations;

public class ImagemConfiguration : IEntityTypeConfiguration<Imagem>
{
    public void Configure(EntityTypeBuilder<Imagem> builder)
    {
        builder.ToTable("Imagem");

        builder.HasKey(i => i.Id);

        builder.Property(i => i.Descricao)
               .HasMaxLength(255); 

        builder.Property(i => i.Url)
               .HasColumnName("Url")
               .HasMaxLength(500); 

        builder.HasOne(i => i.Produto)
               .WithMany(p => p.Imagens)
               .HasForeignKey(i => i.ProdutoId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
