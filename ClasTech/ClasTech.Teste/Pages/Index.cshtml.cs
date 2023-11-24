using ClasTech.Teste.ClassTech.Teste.Service;
using ClasTech.Teste.Data;
using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        private readonly TesteService _service;
        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger, TesteService service)
        {
            _context = context;
            _logger = logger;
            _service = service;
        }

        public IList<PedidoViewModel> ListaDeProdutos { get; set; } = default!;
        public IList<PedidoItemViewModel> ListaDeProdutosItem { get; set; } = default!;

        [BindProperty]
        public PedidoItemViewModel pedidoItem { get; set; } = new();

        [BindProperty]
        public PedidoItemViewModel pedido { get; set; } = new();

        public async Task OnGetAsync()
        {
            if (_context.pedido != null)
            {
                ListaDeProdutos = await _context.pedido.ToListAsync();
                ListaDeProdutosItem = await _context.pedidoItem.ToListAsync();
            }
        }

        public async Task OnPostByName()
        {
            ListaDeProdutosItem = _service.GetOrderByName(pedidoItem.Nome);
        }
    }
}
