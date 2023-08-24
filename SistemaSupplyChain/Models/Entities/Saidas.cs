namespace SistemaSupplyChain.Models.Entities
{
    public class Saidas
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string? Local { get; set; }
        public string? Data { get; set; }
        public string? Hora { get; set; }

        public Produtos? IdProduto { get; set; }
    }
}
