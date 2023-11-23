using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Pages.Views.Home.PedidosItems
{
    public class IndexModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public IndexModel(ClasTech.Teste.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PedidoItemViewModel> PedidoItemViewModel { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.pedidoItem != null)
            {
                PedidoItemViewModel = await _context.pedidoItem.ToListAsync();
            }
        }
    }
}
