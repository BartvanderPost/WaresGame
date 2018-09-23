using Newtonsoft.Json;

namespace Dealer.Logic.Models
{
    public class Ware
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public int Price { get; set; }

        [JsonProperty (PropertyName = "Min-Price")]
        public int MinPrice { get; set; }

        [JsonProperty(PropertyName = "Max-Price")]
        public int MaxPrice { get; set; }
    }
}
