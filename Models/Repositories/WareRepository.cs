using System;
using System.Collections.Generic;
using Dealer.Logic.Models;

namespace Dealer.Logic.Repositories
{
    public class WareRepository : IWareRepository
    {
        private IConfigRepository _configRepository;

        public WareRepository() { }

        public WareRepository(IConfigRepository configRepository )
        {
            this._configRepository = configRepository;
        }
        public IEnumerable<Ware> GetWares()
        {
            var wares = _configRepository.GetWaresFromConfig();
            return wares.Products;
        }
    }
}
