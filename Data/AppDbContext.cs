using InventarioClientes.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace InventarioClientes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductoModel> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

    }
}