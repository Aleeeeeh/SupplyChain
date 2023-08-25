using SistemaSupplyChain.Models.Entities;

namespace SistemaSupplyChain.Services.Interfaces
{
    public interface IProdutoService
    {
        Task<Produtos> CadastrarProduto(Produtos produtos);
        Task<List<Produtos>> BuscarProdutos();
        Task<Saidas> LancarSaidaDeProduto(Saidas saidas);
        Task<Entradas> LancarEntradaDeProduto(Entradas entradas);
        Task<List<Entradas>> BuscarEntradasDeProdutosPorMes(int mes);
        Task<List<Entradas>> BuscarEntradasDeProdutoEmes(int mes, int idProduto);
        Task<List<Saidas>> BuscarSaidasDeProdutosPorMes(int mes);
        Task<List<Saidas>> BuscarSaidasDeProdutoEmes(int mes, int idProduto);
    }
}
