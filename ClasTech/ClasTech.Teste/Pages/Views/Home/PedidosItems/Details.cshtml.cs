using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Pages.Views.Home.PedidosItems
{
    public class DetailsModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public DetailsModel(ClasTech.Teste.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public PedidoItemViewModel PedidoItemViewModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.pedidoItem == null)
            {
                return NotFound();
            }

            var pedidoitemviewmodel = await _context.pedidoItem.FirstOrDefaultAsync(m => m.Id == id);
            if (pedidoitemviewmodel == null)
            {
                return NotFound();
            }
            else
            {
                PedidoItemViewModel = pedidoitemviewmodel;
            }
            return Page();
        }
    }
}
