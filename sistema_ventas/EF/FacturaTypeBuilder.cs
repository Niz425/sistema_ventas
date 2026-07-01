using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sistema_ventas.Clases;

namespace sistema_ventas.EF
{
    public class FacturaTypeBuilder : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            // throw new NotImplementedException();
            builder.HasKey(p => p.IdFactura);
            builder.Property(p => p.IdFactura).HasColumnName("ID_FACTURA");
            builder.Property(p => p.Fecha).HasColumnName("FECHA");
            builder.Property(p => p.IdCliente).HasColumnName("ID_CLIENTE");
            builder.HasOne(fk => fk.Cliente).WithMany().HasForeignKey(fk => fk.IdCliente);
            builder.ToTable("FACTURAS");
        }
    }
}
