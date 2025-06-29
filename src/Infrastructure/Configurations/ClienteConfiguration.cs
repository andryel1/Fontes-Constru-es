using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
       builder.ToTable("Cliente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(c => c.Cpf)
                .HasMaxLength(14) 
                .IsRequired(false);

            builder.Property(c => c.Password)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(c => c.Telefone)
                .HasMaxLength(20)
                .IsRequired(false);

            builder.Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(c => c.DataNascimento)
                .IsRequired();

          
    }
}