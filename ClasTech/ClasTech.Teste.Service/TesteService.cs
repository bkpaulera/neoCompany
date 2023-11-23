namespace ClasTech.Teste.Service
{
    public class TesteService
    {

        //- Consultar o pedido que tenha o maior valor total
        public void GetOrderHighestValue() { }

        // - Consultar pedidos item por nome
        public string GetOrderByName(string name)
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
                        return name;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }

        // - Consultar apenas os pedidos ativos
        public void GetActiveOrders() { 
        
        }

        // - Consultar apenas pedidos realizados no ano de 2017
        public void GetOrderByYear() { }

        // - Consultar pedidos item(de todos os pedidos) onde o valor seja menor que R$ 18,50
        public void GetItemOrderByValue() { }

    }
}
