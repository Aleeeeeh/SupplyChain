namespace SistemaSupplyChain.Models.Entities
{
    public class Produtos
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? NumeroRegistro { get; set; }
        public string? Fabricante { get; set; }
        public string? TipoProduto { get; set; }
        public string? Descricao { get; set; }

    }
}
