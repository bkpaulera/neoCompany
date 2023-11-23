using ClasTech.Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClasTech.Teste.Pages.Views.Home.PedidosItems
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
        public PedidoItemViewModel PedidoItemViewModel { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.pedidoItem == null || PedidoItemViewModel == null)
            {
                return Page();
            }

            _context.pedidoItem.Add(PedidoItemViewModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
