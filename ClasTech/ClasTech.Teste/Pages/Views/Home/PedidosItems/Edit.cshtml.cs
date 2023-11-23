using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.Pages.Views.Home.PedidosItems
{
    public class EditModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public EditModel(ClasTech.Teste.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            PedidoItemViewModel = pedidoitemviewmodel;
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

            _context.Attach(PedidoItemViewModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoItemViewModelExists(PedidoItemViewModel.Id))
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

        private bool PedidoItemViewModelExists(int id)
        {
            return (_context.pedidoItem?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
