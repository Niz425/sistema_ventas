using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sistema_ventas.Clases;

namespace sistema_ventas.EF
{
    public class ProductoTypeBuilder : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            // throw new NotImplementedException();
            builder.HasKey(p => p.IdProducto);
            builder.Property(p => p.IdProducto).HasColumnName("ID_PRODUCTO");
            builder.Property(p => p.Descripcion).HasColumnName("DESCRIPCION").HasMaxLength(150);
            builder.Property(p => p.Precio).HasColumnName("PRECIO").HasColumnType("decimal(9,2)");
            // builder.Property(p => p.Categoria.IdCategoria).HasColumnName("ID_CATEGORIA");
            // builder.Property(p => p.Proveedor.ID).HasColumnName("ID_PROVEEDOR");
            builder.Property(p => p.Stock).HasColumnName("STOCK");
            builder.HasOne(fk => fk.Categoria).WithMany().HasForeignKey(fk => fk.IdCategoria);
            builder.HasOne(fk => fk.Proveedor).WithMany().HasForeignKey(fk => fk.IdProveedor);
            //builder.HasOne(k => k.Categoria).HasForeignKey(k => k.IdCategoria);
            builder.ToTable("PRODUCTOS");
        }
    }
}
