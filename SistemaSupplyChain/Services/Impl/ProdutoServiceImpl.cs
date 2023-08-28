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

        public int TotalEntradasDeProdutoEmes(int mes, int idProduto, int ano)
        {
            return _dbcontext.Entradas.Where(e => e.DataEHora.Month == mes)
                .Where(e => e.DataEHora.Year == ano)
                .Where(e => e.ProdutoID == idProduto)
                .Sum(e => e.Quantidade);
        }

        public async Task<List<Entradas>> BuscarEntradasDeProdutosPorMes(int mes, int ano)
        {
            return await _dbcontext.Entradas.Where(e => e.DataEHora.Month == mes)
                .Where(e => e.DataEHora.Year == ano)
                .Include(p => p.Produto)
                .ToListAsync();
        }

        public async Task<List<Produtos>> BuscarProdutos()
        {
            return await _dbcontext.Produtos.ToListAsync();
        }

        public int TotalSaidasDeProdutoEmes(int mes, int idProduto, int ano)
        {
            return _dbcontext.Saidas.Where(e => e.DataEHora.Month == mes)
                .Where(e => e.DataEHora.Year == ano)
                .Where(e => e.ProdutoID == idProduto)
                .Sum(e => e.Quantidade);
        }

        public async Task<List<Saidas>> BuscarSaidasDeProdutosPorMes(int mes, int ano)
        {
            return await _dbcontext.Saidas.Where(s => s.DataEHora.Month == mes)
                .Where(e => e.DataEHora.Year == ano)
                .Include(p => p.Produto)
                .ToListAsync();
        }

        public async Task<Produtos> CadastrarProduto(Produtos produto)
        {
            await _dbcontext.Produtos.AddAsync(produto);
            _dbcontext.SaveChanges();

            return produto;
        }

        public async Task<Entradas> LancarEntradaDeProduto(Entradas entrada)
        {
            await _dbcontext.Entradas.AddAsync(entrada);
            _dbcontext.SaveChanges();

            return entrada;
        }

        public async Task<Saidas> LancarSaidaDeProduto(Saidas saida)
        {
            await _dbcontext.Saidas.AddAsync(saida);
            _dbcontext.SaveChanges();

            return saida;
        }
    }
}
