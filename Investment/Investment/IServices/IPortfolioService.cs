using Investment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.IServices
{
    public interface IPortfolioService
    {
        IEnumerable<Portfolio> GetPortfolio();
        Portfolio AddPortfolio(Portfolio portfolio);
        Portfolio UpdatePortfolio(Portfolio portfolio);
        Portfolio DeletePortfolio(int id);
    }
}
