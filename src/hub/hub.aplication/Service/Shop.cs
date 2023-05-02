using hub.domain;
using hub.domain.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using hub.infrastructure;

namespace hub.aplication.Service
{
    public class Shop:IShop
    {
        
        private readonly ILog _log;
        public Shop(ILog log)
        {
            
            _log = log;
        }

        public List<Produto> BuscarProdutos()
        {
            
            string url = "https://fakestoreapi.com/products";
            HttpClient client= new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json =response.Content.ReadAsStringAsync().Result;
            //string json = client.GetStringAsync(url).Result; forma de fazer riquisição direta 
            List<Produto> todosProdutos =JsonConvert.DeserializeObject<List<Produto>>(json);
            string nomeMetodo = Metodo.Nome();
            LogResgistro log=new LogResgistro(nomeMetodo,url,response.StatusCode.ToString());
            _log.Regitrar(log);
            return todosProdutos;

        } 
        public Produto BuscarProduto(int id)
        {
            string url = "https://fakestoreapi.com/products/";
            HttpClient client = new HttpClient();
            //fazer requisição nesse formato pode pegar a mensagem de statuscode
            HttpResponseMessage response = client.GetAsync(url+id).Result;
            //pega resultado e transforma em uma string
            string json = response.Content.ReadAsStringAsync().Result;
            Produto produtos = JsonConvert.DeserializeObject<Produto>(json);
            string nomeMetodo = Metodo.Nome();
            LogResgistro log = new LogResgistro(nomeMetodo, url, response.StatusCode.ToString());
            _log.Regitrar(log);
            return produtos;
        }
    }
}
