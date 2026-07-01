using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sistema_ventas.Clases;

namespace sistema_ventas.EF
{
    public class VentaTypeBuilder : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            // throw new NotImplementedException();
            builder.HasKey(p => p.IdVenta);
            builder.Property(p => p.IdVenta).HasColumnName("ID_VENTA");
            builder.Property(p => p.IdProducto).HasColumnName("ID_PRODUCTO");
            builder.Property(p => p.IdFactura).HasColumnName("ID_FACTURA");
            builder.Property(p => p.Cantidad).HasColumnName("CANTIDAD");
            builder.HasOne(fk => fk.Producto).WithMany().HasForeignKey(fk => fk.IdProducto);
            builder.HasOne(fk => fk.Factura).WithMany(fk => fk.Ventas).HasForeignKey(fk => fk.IdFactura);
            builder.ToTable("VENTAS");

        }
    }
}
