using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sistema_ventas.Clases;

namespace sistema_ventas.EF
{
    public class MembresiaTypeBuilder : IEntityTypeConfiguration<Membresia>
    {
        public void Configure(EntityTypeBuilder<Membresia> builder)
        {
            // throw new NotImplementedException();
            builder.HasKey(p => p.IdMembresia);
            builder.Property(p => p.IdMembresia).HasColumnName("ID_MEMBRESIA");
            builder.Property(p => p.Descripcion).HasColumnName("DESCRIPCION").HasMaxLength(50);
            builder.ToTable("MEMBRESIAS");

        }
    }
}
