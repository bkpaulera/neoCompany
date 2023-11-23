using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClasTech.Teste.Data;
using ClasTech.Teste.Models;

namespace ClasTech.Teste.Views.Home.ItemPedido
{
    public class DeleteModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public DeleteModel(ClasTech.Teste.Data.ApplicationDbContext context)
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
            else 
            {
                PedidoItemViewModel = pedidoitemviewmodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.pedidoItem == null)
            {
                return NotFound();
            }
            var pedidoitemviewmodel = await _context.pedidoItem.FindAsync(id);

            if (pedidoitemviewmodel != null)
            {
                PedidoItemViewModel = pedidoitemviewmodel;
                _context.pedidoItem.Remove(PedidoItemViewModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
