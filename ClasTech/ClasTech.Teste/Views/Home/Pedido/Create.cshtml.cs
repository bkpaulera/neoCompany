using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClasTech.Teste.Data;
using ClasTech.Teste.Models;

namespace ClasTech.Teste.Views.Home.Pedido
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
