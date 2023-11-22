using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasTech.Teste.Business.Entities;
using ClasTech.Teste.Models;

namespace ClasTech.Teste.Service
{
    public class TesteService
    {
        public IList<TesteViewModel> GetAll()
        {
            try
            {
                using (var db = new clastechTesteEntities())
                {
                    var list = (from t in db.teste
                                select new TesteViewModel
                                {
                                    Id = t.id,
                                    Nome = t.nome,
                                    Ativo = t.ativo
                                }).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
