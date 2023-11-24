using ClasTech.Teste.ClassTech.Teste.Service;
using ClasTech.Teste.Data;
using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Pages
{
    public class ItemPedidosModel : PageModel
    {
        private readonly TesteService _service;
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public ItemPedidosModel(ApplicationDbContext context, TesteService service)
        {
           
            _context = context;
            _service = service;
        }

        public IList<PedidoItemViewModel> ListaDePedidoItem { get; set; } = default!;

        [BindProperty]
        public PedidoItemViewModel pedidoItem { get; set; } = new();
        public async Task OnGetAsync()
        {
            if (_context.pedido != null)
            {
                ListaDePedidoItem = await _context.pedidoItem.ToListAsync();
            }
        }

        public async Task OnPostByName()
        {
            ListaDePedidoItem = _service.GetOrderByName(pedidoItem.Nome);
        }

        public async Task OnPostByValue()
        {
            ListaDePedidoItem = _service.GetOrderByValue((decimal)18.50);
        }
    }
}
