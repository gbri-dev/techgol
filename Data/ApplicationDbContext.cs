using Microsoft.EntityFrameworkCore;
using pratice_web.Models;

namespace pratice_web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Produto { get; set; }
        public DbSet<Category> Categorias { get; set; }
    }
}
