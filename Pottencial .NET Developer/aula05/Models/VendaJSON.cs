using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace aula05.Models
{
    public class VendaJSON
    {
        public int Id { get; set; }
        
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

    }
}
