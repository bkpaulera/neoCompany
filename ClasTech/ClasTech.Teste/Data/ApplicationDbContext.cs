using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Data
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PedidoViewModel> pedido { get; set; } = default;
        public DbSet<PedidoItemViewModel> pedidoItem { get; set; } = default;

    }
}
