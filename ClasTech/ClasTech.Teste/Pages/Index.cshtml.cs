using ClasTech.Teste.Data;
using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<PedidoViewModel> ListaDeProdutos { get; set; } = default!;
        public IList<PedidoItemViewModel> ListaDeProdutosItem { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.pedido != null)
            {
                ListaDeProdutos = await _context.pedido.ToListAsync();
                ListaDeProdutosItem = await _context.pedidoItem.ToListAsync();
            }
        }
    }
}
