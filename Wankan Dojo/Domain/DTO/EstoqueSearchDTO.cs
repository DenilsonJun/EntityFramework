namespace Domain.DTO
{
    public class EstoqueSearchDTO
    {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public string NomeProduto { get; set; }
        public string Observacao { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal Compra { get; set; }
        public decimal Venda { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}
