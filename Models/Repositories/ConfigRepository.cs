using System.Collections.Generic;
using Dealer.Logic.Models;
using Newtonsoft.Json;

namespace Dealer.Logic.Repositories
{
    public class ConfigRepository : IConfigRepository
    {
        public Wares GetWaresFromConfig()
        {
            //TODO: path variable 
            var json = System.IO.File.ReadAllText(@"F:\Projects\Dealer\Models\Config\Wares.json");
            var converter = JsonConvert.DeserializeObject<Wares>(json);
            return converter;
        }
    }
}
