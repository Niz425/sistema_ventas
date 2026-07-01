using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sistema_ventas.Clases;

namespace sistema_ventas.EF
{
    public class ClienteTypeBuilder : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // throw new NotImplementedException();
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).HasColumnName("ID_CLIENTE");
            builder.Property(p => p.Nombre).HasColumnName("NOMBRE").HasMaxLength(100);
            builder.Property(p => p.Direccion).HasColumnName("DIRECCION").HasMaxLength(250);
            builder.Property(p => p.Telefono).HasColumnName("TELEFONO").HasMaxLength(15);
            builder.Property(p => p.IdMembresia).HasColumnName("ID_MEMBRESIA");
            builder.HasOne(fk => fk.Membresia).WithMany().HasForeignKey(fk => fk.IdMembresia);
            builder.ToTable("CLIENTES");

        }
    }
}
