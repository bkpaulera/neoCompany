using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClasTech.Teste.Data;
using ClasTech.Teste.Models;

namespace ClasTech.Teste.Views.Home.Pedido
{
    public class DeleteModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public DeleteModel(ClasTech.Teste.Data.ApplicationDbContext context)
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
            else 
            {
                PedidoViewModel = pedidoviewmodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.pedido == null)
            {
                return NotFound();
            }
            var pedidoviewmodel = await _context.pedido.FindAsync(id);

            if (pedidoviewmodel != null)
            {
                PedidoViewModel = pedidoviewmodel;
                _context.pedido.Remove(PedidoViewModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
