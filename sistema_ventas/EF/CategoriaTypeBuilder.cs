using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sistema_ventas.Clases;

namespace sistema_ventas.EF
{
    public class CategoriaTypeBuilder : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // throw new NotImplementedException();
            builder.HasKey(p => p.IdCategoria);
            builder.Property(p => p.IdCategoria).HasColumnName("ID_CATEGORIA");
            builder.Property(p => p.Descripcion).HasColumnName("DESCRIPCION").HasMaxLength(100);
            builder.ToTable("CATEGORIAS");

        }
    }
}
