using ClasTech.Teste.Service;

namespace ClasTech.Teste.Tests.Controllers
{
    [TestClass]
    public class TesteController
    {
        private TesteService _service;

        [TestInitialize]
        public void TestInitialize()
        {
            _service = new TesteService();
        }

        [TestMethod]
        public void Index() { }

        [TestMethod]
        //- Consultar o pedido que tenha o maior valor total
        public void GetOrderHighestValue() { }

        [TestMethod]
        [DataTestMethod]
        [DataRow("PEDIDO")]
        [DataRow("pedido 1")]
        // - Consultar pedidos item por nome
        public void GetOrderByName(string order)
        {
           
            var value = _service.GetOrderByName("PEDIDO");

            Assert.IsTrue(order == value);
        }

        [TestMethod]
        // - Consultar apenas os pedidos ativos
        public void GetActiveOrders() { }
        [TestMethod]
        // - Consultar apenas pedidos realizados no ano de 2017
        public void GetOrderByYear() { }
        [TestMethod]
        // - Consultar pedidos item(de todos os pedidos) onde o valor seja menor que R$ 18,50
        public void GetItemOrderByValue() { }


    }
}