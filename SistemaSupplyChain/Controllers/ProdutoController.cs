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
            List<Produtos> produtos =  await _produtoService.BuscarProdutos();
            return Ok(produtos);
        }
        /*
        [HttpGet]
        public async Task<ActionResult<List<object>>> buscarMovimentacaoProdutoPorMes([FromQuery(Name = "mes")] string numeroMes)
        {
            List<object> movimentacaoProdutos = await _produtoService.BuscarEntradasESaidasDeProdutosPorMes(numeroMes);

            return Ok(movimentacaoProdutos);
        }
        */
        [HttpPost]
        public async Task<ActionResult<Produtos>> cadastrarProduto([FromBody]Produtos produtos)
        {
            Produtos produto = await _produtoService.CadastrarProduto(produtos);

            return Ok(produto);
        }

        [HttpPost("/Entrada")]
        public async Task<ActionResult<Entradas>> EntradaDeMercadoria([FromBody]Entradas entradas)
        {
            Entradas entrada = await _produtoService.LancarEntradaDeProduto(entradas);

            return Ok(entrada);
        }

        [HttpPost("/Saida")]
        public async Task<ActionResult<Entradas>> EntradaDeMercadoria([FromBody] Saidas saidas)
        {
            Saidas saida = await _produtoService.LancarSaidaDeProduto(saidas);

            return Ok(saida);
        }

    }
}
