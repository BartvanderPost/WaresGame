using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dealer.Logic.Models
{
    public class Wares
    {
        [JsonProperty (PropertyName ="Wares")]
        public IEnumerable<Ware> Products { get; set; }
    }
}
