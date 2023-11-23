namespace ClasTech.Teste.Models
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
        public bool Ativo { get; set; }

        public List<PedidoItemViewModel> pedidoItem { get; set; }
    }
}
