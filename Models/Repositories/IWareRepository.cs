using Dealer.Logic.Models;
using System.Collections.Generic;

namespace Dealer.Logic.Repositories
{
    public interface IWareRepository
    {
        IEnumerable<Ware> GetWares();
    }
}
