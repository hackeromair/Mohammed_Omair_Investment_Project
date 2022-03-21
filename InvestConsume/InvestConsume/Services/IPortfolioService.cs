using InvestConsume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestConsume.Services
{
    public interface IPortfolioService
    {
        Task<List<Portfolio>> GetPortfolio();

        Task<bool> SavePortfolio(Portfolio portfolio);

    }
}
