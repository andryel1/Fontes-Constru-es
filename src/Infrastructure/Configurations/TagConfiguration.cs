using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tags");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(t => t.Produto)
                .WithMany(p => p.Tags)
                .HasForeignKey(t => t.ProdutoId);
        }   
    }
}