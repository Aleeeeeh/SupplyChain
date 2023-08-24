using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaSupplyChain.Models.Entities;

namespace SistemaSupplyChain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Produtos>> buscarProdutosCadastrados()
        {
            return Ok();
        }
    }
}
