using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClasTech.Teste.Data;
using ClasTech.Teste.Models;

namespace ClasTech.Teste.Views.Home
{
    public class ItemsPedidoModel : PageModel
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public ItemsPedidoModel(ClasTech.Teste.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PedidoItemViewModel> PedidoItemViewModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.pedidoItem != null)
            {
                PedidoItemViewModel = await _context.pedidoItem.ToListAsync();
            }
        }
    }
}
