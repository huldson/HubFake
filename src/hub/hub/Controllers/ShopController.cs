using hub.domain;
using hub.domain.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace hub.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ShopController : Controller
    {
        private readonly IShop _shop;

        public ShopController(IShop shop)
        {
            _shop = shop;
        }

        [HttpGet("consultarprodutos")]
        
        public List<Produto> ConsultarTodosOsProdutos() {
        
            return _shop.BuscarProdutos();
        }
        [HttpGet("consultarproduto")]
        public Produto consultarProdutoPorId([FromQuery]int id) {
            return _shop.BuscarProduto(id);

        }
    }
}
