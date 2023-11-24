using ClasTech.Teste.Data;
using ClasTech.Teste.Models;

namespace ClasTech.Teste.ClassTech.Teste.Service
{
    public class TesteService
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public TesteService(ApplicationDbContext context) { 
            _context = context;
        }

        public IList<PedidoItemViewModel> GetOrderByName(string name)
        {
            var value = _context.pedidoItem
            .Where(p => p.Nome == name)
            .ToList();
            return value;
        }
    }
}
