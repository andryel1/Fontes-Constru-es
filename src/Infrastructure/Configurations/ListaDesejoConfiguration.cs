using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("ListaDesejo");

            builder.HasKey(ld => ld.Id);

            builder.Property(ld => ld.DataAdicionada)
                   .IsRequired();

            builder.HasMany(ld => ld.Produtos)
                   .WithMany();

            builder.HasOne(ld => ld.Cliente)
                   .WithMany(ld => ld.ListaDesejo)
                   .HasForeignKey(ld => ld.ClienteId)
                   .IsRequired();
        }
    }
}