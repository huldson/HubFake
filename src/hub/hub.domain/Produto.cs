using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hub.domain
{
    public class Produto
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Title")]
        public string? Titulo { get; set; }
        [JsonProperty("Description")]
        public string? Descricao { get; set; }
        [JsonProperty("Price")]
        public decimal? Preco { get; set; }
        [JsonProperty("Category")]
        public string? Categoria { get; set; }
        [JsonProperty("Image")]
        public string? Imagem { get; set; }
    }
}
