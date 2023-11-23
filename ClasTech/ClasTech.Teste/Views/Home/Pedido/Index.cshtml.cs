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
    public class IndexModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public IndexModel(ClasTech.Teste.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PedidoViewModel> PedidoViewModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.pedido != null)
            {
                PedidoViewModel = await _context.pedido.ToListAsync();
            }
        }
    }
}
