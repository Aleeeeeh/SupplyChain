using SistemaSupplyChain.Models.Entities;

namespace SistemaSupplyChain.Services.Interfaces
{
    public interface IProdutoService
    {
        Task<Produtos> CadastrarProduto(Produtos produtos);
        Task<List<Produtos>> BuscarProdutos();
        Task<Saidas> LancarSaidaDeProduto(Saidas saidas);
        Task<Entradas> LancarEntradaDeProduto(Entradas entradas);
        Task<List<object>> BuscarEntradasESaidasDeProdutosPorMes(string mes);
        Task<List<object>> BuscarEntradasESaidasDeProdutoEmes(string mes, int idProduto);
    }
}
