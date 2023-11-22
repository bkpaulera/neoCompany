using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasTech.Teste.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClasTech.Teste.Tests.Controllers
{
    [TestClass]
    public class TesteControllerTest
    {
        [TestMethod]
        public void Index()
        {
            var service = new TesteService();

            var lista = service.GetAll();
        }
    }
}
