using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaleSoft.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSoft.Datos.Mapping.Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria")
                .HasKey(c => c.idcategoria);
        }
    }
}
