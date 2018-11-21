using Microsoft.EntityFrameworkCore;
using Repaso_RCV.Models;

namespace Repaso_RCV.Context
{
    public class BDContext : DbContext
    {
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public BDContext(DbContextOptions<BDContext> dbo) : base(dbo)
        {            }
    }
}