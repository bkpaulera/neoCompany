using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClasTech.Teste.Data;
using ClasTech.Teste.Models;

namespace ClasTech.Teste.Views.Home.ItemPedido
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
