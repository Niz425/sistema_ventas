using Microsoft.EntityFrameworkCore;
using sistema_ventas.Clases;

namespace sistema_ventas.EF
{
    public class AppDBContext : DbContext
    {
        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Proveedor> Proveedores => Set<Proveedor>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Venta> Ventas => Set<Venta>();
        public DbSet<Factura> Facturas => Set<Factura>();
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=10.143.193.142,1433;Database=sistema_ventas;User Id=mati;Password=Mati.5327;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;Integrated Security=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);

        }

    }
}
