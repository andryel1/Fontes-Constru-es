using Microsoft.EntityFrameworkCore;
using Ecommerce.Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure
{
   public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
}