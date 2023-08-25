namespace SistemaSupplyChain.Models.Entities
{
    public class Saidas
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string? Local { get; set; }
        public DateTime DataEHora{ get; set; }
        public int? ProdutoID { get; set; }
        public virtual Produtos? Produto { get; set; }
    }
}
