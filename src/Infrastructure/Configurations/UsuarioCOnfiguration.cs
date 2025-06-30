using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations;
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.UserName);

        builder.Property(u => u.Password);

        builder.Property(u => u.Email);

        builder.Property(u => u.DataNascimento)
        .HasColumnType("datetime");

        builder.HasOne(u => u.Cliente)
        .WithOne(cliente => cliente.Usuario)
        .HasForeignKey<Cliente>(cliente => cliente.UsuarioId);
    }
}