using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaSupplyChain.Models.Entities;
using SistemaSupplyChain.Services.Interfaces;

namespace SistemaSupplyChain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produtos>>> buscarProdutosCadastrados()
        {
            List<Produtos> produtos = await _produtoService.BuscarProdutos();
            return Ok(produtos);
        }

        [HttpGet("filtroMesEntrada")]
        public async Task<ActionResult<List<Entradas>>> buscarMovimentacaoProdutoEntradaPorMes([FromQuery(Name = "mes")] int numeroMes, [FromQuery(Name = "ano")] int ano)
        {
            List<Entradas> movimentacaoProdutosEntrada = await _produtoService.BuscarEntradasDeProdutosPorMes(numeroMes,ano);

            return Ok(movimentacaoProdutosEntrada);
        }

        [HttpGet("filtroMesSaida")]
        public async Task<ActionResult<List<Saidas>>> buscarMovimentacaoProdutoSaidaPorMes([FromQuery(Name = "mes")] int numeroMes, [FromQuery(Name = "ano")] int ano)
        {
            List<Saidas> movimentacaoProdutosSaida = await _produtoService.BuscarSaidasDeProdutosPorMes(numeroMes,ano);

            return Ok(movimentacaoProdutosSaida);
        }

        [HttpGet("totalEntradaMesProduto")]
        public ActionResult<int> buscarMovimentacaoDeEntradasPorMesEProduto([FromQuery(Name = "mes")] int numeroMes, [FromQuery(Name = "ProdutoID")] int produtoID, [FromQuery(Name = "ano")] int ano)
        {
            int movimentacaoDeProdutoPorMesEntrada = _produtoService.TotalEntradasDeProdutoEmes(numeroMes,produtoID,ano);

            return Ok(movimentacaoDeProdutoPorMesEntrada);
        }

        [HttpGet("totalSaidaMesProduto")]
        public ActionResult<int> buscarMovimentacaoDeSaidasPorMesEProduto([FromQuery(Name = "mes")] int numeroMes, [FromQuery(Name = "ProdutoID")] int produtoID, [FromQuery(Name = "ano")] int ano)
        {
            int movimentacaoDeProdutoPorMesSaida = _produtoService.TotalSaidasDeProdutoEmes(numeroMes,produtoID,ano);

            return Ok(movimentacaoDeProdutoPorMesSaida);
        }

        [HttpPost]
        public async Task<ActionResult<Produtos>> cadastrarProduto([FromBody]Produtos produtos)
        {
            Produtos produto = await _produtoService.CadastrarProduto(produtos);

            return Ok(produto);
        }

        [HttpPost("Entrada")]
        public async Task<ActionResult<Entradas>> EntradaDeMercadoria([FromBody]Entradas entradas)
        {
            Entradas entrada = await _produtoService.LancarEntradaDeProduto(entradas);

            return Ok(entrada);
        }

        [HttpPost("Saida")]
        public async Task<ActionResult<Entradas>> EntradaDeMercadoria([FromBody] Saidas saidas)
        {
            Saidas saida = await _produtoService.LancarSaidaDeProduto(saidas);

            return Ok(saida);
        }

    }
}
