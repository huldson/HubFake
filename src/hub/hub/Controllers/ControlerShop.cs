using hub.domain;
using hub.domain.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace hub.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ControlerShop : Controller
    {
        private readonly IShop _shop;

        public ControlerShop(IShop shop)
        {
            _shop = shop;
        }

        [HttpGet("consultarprodutos")]
        
        public List<Produto> consultarprodutos() {
        
            return _shop.BuscarProdutos();
        }
        [HttpGet("consultarproduto")]
        public Produto consultarProduto([FromQuery]int id) {
            return _shop.Buscarproduto(id);

        }
    }
}
