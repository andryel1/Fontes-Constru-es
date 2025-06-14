using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations
{
    public class AvaliacaoConfiguration : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacoes");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nota)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(a => a.Comentario)
                .IsRequired()
                .HasMaxLength(500)
                .HasColumnType("varchar(500)");

            builder.Property(a => a.Data)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(a => a.Cliente)
                .WithMany()
                .HasForeignKey("ClienteId")
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Produto)
                .WithMany(p => p.Avaliacoes)
                .HasForeignKey("ProdutoId")
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 