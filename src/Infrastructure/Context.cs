namespace Infrastructure
{
    public class Context : DbContext
    {
        // Construtor que recebe as opções do contexto
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
