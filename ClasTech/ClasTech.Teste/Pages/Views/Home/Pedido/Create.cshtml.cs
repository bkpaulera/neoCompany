using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Pages.Views.Home.Pedido
{
    public class CreateModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public CreateModel(ClasTech.Teste.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PedidoViewModel PedidoViewModel { get; set; } = default!;

        public IList<PedidoItemViewModel> PedidoItemViewModel { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.pedidoItem != null)
            {
                PedidoItemViewModel = await _context.pedidoItem.ToListAsync();
            }
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.pedido == null || PedidoViewModel == null)
            {
                return Page();
            }

            _context.pedido.Add(PedidoViewModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
