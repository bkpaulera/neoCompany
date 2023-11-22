using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClasTech.Teste.Models;
using ClasTech.Teste.Service;

namespace ClasTech.Teste.Controllers
{
    public class TesteController : ApiController
    {
        private readonly TesteService _testeService;

        public TesteController()
        {
            _testeService = new TesteService();
        }

        [HttpPost]
        public IList<TesteViewModel> GetAll()
        {
            return _testeService.GetAll();
        }
    }
}
