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

        public async Task<List<Entradas>> BuscarEntradasDeProdutoEmes(int mes, int idProduto)
        {
            return await _dbcontext.Entradas.Where(e => e.DataEHora.Month == mes).Where(e => e.ProdutoID == idProduto).Include(e => e.Produto).ToListAsync();
        }

        public async Task<List<Entradas>> BuscarEntradasDeProdutosPorMes(int mes)
        {
            return await _dbcontext.Entradas.Where(e => e.DataEHora.Month == mes).Include(p => p.Produto).ToListAsync();
        }

        public async Task<List<Produtos>> BuscarProdutos()
        {
            return await _dbcontext.Produtos.ToListAsync();
        }

        public async Task<List<Saidas>> BuscarSaidasDeProdutoEmes(int mes, int idProduto)
        {
            return await _dbcontext.Saidas.Where(e => e.DataEHora.Month == mes).Where(e => e.ProdutoID == idProduto).Include(e => e.Produto).ToListAsync();
        }

        public async Task<List<Saidas>> BuscarSaidasDeProdutosPorMes(int mes)
        {
            return await _dbcontext.Saidas.Where(s => s.DataEHora.Month == mes).Include(p => p.Produto).ToListAsync();
        }

        public async Task<Produtos> CadastrarProduto(Produtos produto)
        {
            await _dbcontext.Produtos.AddAsync(produto);
            _dbcontext.SaveChanges();

            return produto;
        }

        public async Task<Entradas> LancarEntradaDeProduto(Entradas entrada)
        {
            await _dbcontext.AddAsync(entrada);
            _dbcontext.SaveChanges();

            return entrada;
        }

        public async Task<Saidas> LancarSaidaDeProduto(Saidas saida)
        {
            await _dbcontext.AddAsync(saida);
            _dbcontext.SaveChanges();

            return saida;
        }
    }
}
