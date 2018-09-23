using Dealer.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dealer.Logic.Repositories
{
    public interface IConfigRepository
    {
        Wares GetWaresFromConfig();
    }
}
