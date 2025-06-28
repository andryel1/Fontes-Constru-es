using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations;
public class InformacoesEnvioConfiguration : IEntityTypeConfiguration<InformacoesEnvio>
{
    public void Configure(EntityTypeBuilder<InformacoesEnvio> builder)
    {
    
    }
}