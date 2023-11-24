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

        public IList<PedidoViewModel> ListaDePedido { get; set; } = default!;
        


        [BindProperty]
        public PedidoViewModel pedido { get; set; } = new();

        public async Task OnGetAsync()
        {
            if (_context.pedido != null)
            {
                ListaDePedido = await _context.pedido.ToListAsync();
            }
        }

        public async Task OnPostByHighestValue()
        {
            ListaDePedido = _service.GetOrderHighestValue();
        }

        public async Task OnPostByActive()
        {
            ListaDePedido = _service.GetOrderActive();
        }
        public async Task OnPostByYear()
        {
            ListaDePedido = _service.GetOrderByYear();
        }
    }
}
