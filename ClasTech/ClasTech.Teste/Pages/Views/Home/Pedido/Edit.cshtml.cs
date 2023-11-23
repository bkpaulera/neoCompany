using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Pages.Views.Home.Pedido
{
    public class EditModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public EditModel(ClasTech.Teste.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PedidoViewModel PedidoViewModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.pedido == null)
            {
                return NotFound();
            }

            var pedidoviewmodel = await _context.pedido.FirstOrDefaultAsync(m => m.Id == id);
            if (pedidoviewmodel == null)
            {
                return NotFound();
            }
            PedidoViewModel = pedidoviewmodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PedidoViewModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoViewModelExists(PedidoViewModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PedidoViewModelExists(int id)
        {
            return (_context.pedido?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
