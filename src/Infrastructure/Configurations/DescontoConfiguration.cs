using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations;

public class DescontoConfiguration : IEntityTypeConfiguration<Desconto>
{
    public void Configure(EntityTypeBuilder<Desconto> builder)
    {
        builder.ToTable("Desconto");

        builder.HasKey(d => d.Id);
        builder.Property(d => d.Nome);

        builder.Property(d => d.Ativo);

        builder.HasMany(d => d.Produtos)
        .WithMany(d => d.Desconto)
        .HasForeignKey("ClienteId");

        builder.Property(d => d.Valor);

        builder.Property(c => c.DataInicio)
        .IsRequired()
        .HasColumnType("datetime");

        builder.Property(c => c.DataFim)
        .IsRequired()
        .HasColumnType("datetime");
        

    }
}