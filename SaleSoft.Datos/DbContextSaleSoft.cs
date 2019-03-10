using Microsoft.EntityFrameworkCore;
using SaleSoft.Datos.Mapping.Almacen;
using SaleSoft.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSoft.Datos
{
    public class DbContextSaleSoft: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbContextSaleSoft(DbContextOptions<DbContextSaleSoft> options): base(options)
        {

        }

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
