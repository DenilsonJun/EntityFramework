﻿
namespace Domain.EF.Entity
{
    public class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Compra { get; set; }
        public decimal Venda { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}
