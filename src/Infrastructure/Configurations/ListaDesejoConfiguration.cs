using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations
{
    public class ListaDesejoConfiguration : IEntityTypeConfiguration<ListaDesejo>
    {
        public void Configure(EntityTypeBuilder<ListaDesejo> builder)
        {
            builder.ToTable("ListaDesejo");

            builder.HasKey(c => c.Id);
        }
    }
}