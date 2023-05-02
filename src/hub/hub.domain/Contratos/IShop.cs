using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hub.domain.Contratos
{
    public interface IShop
    {
        List<Produto> BuscarProdutos();
        Produto BuscarProduto(int id);
    }
}
