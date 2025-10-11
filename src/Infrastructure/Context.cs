﻿using Microsoft.EntityFrameworkCore;
using Ecommerce.Domain.Entities;
using Infrastructure.Configurations;

namespace Infrastructure
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<ItemCarrinho> ItensCarrinho { get; set; }
        public DbSet<ListaDesejo> ListasDesejo { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Desconto> Descontos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<DetalhePedido> DetalhesPedido { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<InformacoesEnvio> InformacoesEnvios { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<EnviarEmail> Emails { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AvaliacaoConfiguration());
            modelBuilder.ApplyConfiguration(new CarrinhoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new ListaDesejoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new DescontoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new DetalhePedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemCarrinhoConfiguration());
            modelBuilder.ApplyConfiguration(new InformacoesEnvioConfiguration());
            modelBuilder.ApplyConfiguration(new ImagemConfiguration());
        }
    }
}