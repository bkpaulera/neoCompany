namespace ClasTech.Teste.Models
{
    public class PedidoItemViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}
