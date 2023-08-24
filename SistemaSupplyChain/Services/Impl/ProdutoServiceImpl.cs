using Microsoft.EntityFrameworkCore;
using SistemaSupplyChain.Data;
using SistemaSupplyChain.Models.Entities;
using SistemaSupplyChain.Services.Interfaces;

namespace SistemaSupplyChain.Services.Impl
{
    public class ProdutoServiceImpl : IProdutoService
    {
        private readonly SistemaSupplyChainContext _dbcontext;

        public ProdutoServiceImpl(SistemaSupplyChainContext context)
        {
            _dbcontext = context;
        }

        public Task<List<object>> BuscarEntradasESaidasDeProdutoEmes(string mes, int idProduto)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> BuscarEntradasESaidasDeProdutosPorMes(string mes)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Produtos>> BuscarProdutos()
        {
            return await _dbcontext.Produtos.ToListAsync();
        }

        public async Task<Produtos> CadastrarProduto(Produtos produto)
        {
            await _dbcontext.Produtos.AddAsync(produto);
            _dbcontext.SaveChanges();

            return produto;
        }

        public Task<Entradas> LancarEntradaDeProduto(Entradas entradas)
        {
            throw new NotImplementedException();
        }

        public Task<Saidas> LancarSaidaDeProduto(Saidas saidas)
        {
            throw new NotImplementedException();
        }
    }
}
