using Microsoft.EntityFrameworkCore;

namespace pjt.apc.crud.produto.api.Models
{
    public class ProdutosContext : DbContext
    {
        public ProdutosContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Produtos> Produtos { get; set; }
    }
}