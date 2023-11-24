using ClasTech.Teste.Data;
using ClasTech.Teste.Models;
using Microsoft.EntityFrameworkCore;

namespace ClasTech.Teste.ClassTech.Teste.Service
{
    public class TesteService
    {
        private readonly ClasTech.Teste.Data.ApplicationDbContext _context;

        public TesteService(ApplicationDbContext context) { 
            _context = context;
        }


        //Item Pedido
        public IList<PedidoItemViewModel> GetOrderByName(string name)
        {
            if (name == "" || name ==null) {
               
                return _context.pedidoItem.ToList();
            }
            else
            {
                var value = _context.pedidoItem
                .Where(p => p.Nome == name)
                .ToList();
                return value;
            }
        }
        public IList<PedidoItemViewModel> GetOrderByValue(decimal currentValue)
        {
            var value = _context.pedidoItem
            .Where(p => p.Valor < currentValue)
            .ToList();

            return value;
        }

        //Pedido
        public PedidoViewModel GetOrderHighestValue()
        {
            var pedidos = _context.pedido
            .OrderByDescending(p => p.ValorTotal)
            .FirstOrDefault();

            return pedidos;

        }

        public IList<PedidoViewModel> GetOrderActive()
        {
            var pedidos = _context.pedido
            .Where(p => p.Ativo)
            .ToList();

            return pedidos;
        }
        
        public IList<PedidoViewModel> GetOrderByYear()
        {
            var pedidos = _context.pedido
            .Where(p => p.DataPedido.Year == 2017)
            .ToList();

            return pedidos;
        }


    }
}
