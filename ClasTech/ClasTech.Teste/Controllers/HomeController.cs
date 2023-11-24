using ClasTech.Teste.Models;
using ClasTech.Teste.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClasTech.Teste.Controllers
{
    public class HomeController : ApiController
    {
        private readonly TesteService _testeService;
        
        public HomeController()
        {
            _testeService = new TesteService();
        }

        [HttpPost]
        //- Consultar o pedido que tenha o maior valor total
        public Task GetOrderHighestValue()
        {

            return null;
        }


        [HttpPost]
        // - Consultar pedidos item por nome
        public string GetOrderByName(string name)
        {
            return name;
        }


        [HttpPost]
        // - Consultar apenas os pedidos ativos
        public void GetActiveOrders() { }

        // - Consultar apenas pedidos realizados no ano de 2017

        [HttpPost]
        public void GetOrderByYear() { }

        // - Consultar pedidos item(de todos os pedidos) onde o valor seja menor que R$ 18,50

        [HttpPost] 
        public void GetItemOrderByValue() { }
    }
}
