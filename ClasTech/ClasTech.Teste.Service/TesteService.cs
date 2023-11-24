
using ClasTech.Teste.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClasTech.Teste.Service
{
    public class TesteService
    {
    
        //- Consultar o pedido que tenha o maior valor total
        public void GetOrderHighestValue() {
            
        }

        // - Consultar pedidos item por nome
        public IList<PedidoItemViewModel> GetOrderByName(string name)
        {

            ListaDeProdutosItem = _context.pedidoItem
            .Where(p => p.Nome == pedidoItem.Nome)
            .ToList();
        }

        // - Consultar apenas os pedidos ativos
        public void GetActiveOrders() { }

        // - Consultar apenas pedidos realizados no ano de 2017
        public void GetOrderByYear() { }

        // - Consultar pedidos item(de todos os pedidos) onde o valor seja menor que R$ 18,50
        public void GetItemOrderByValue() { }

    }
}
