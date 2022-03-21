using Investment.IServices;
using Investment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Services
{
    public class PortfolioService : IPortfolioService
    {
        investmentAPIContext dbContext;
        public PortfolioService(investmentAPIContext db)
        {
            dbContext = db;
        }

        public Portfolio AddPortfolio(Portfolio portfolio)
        {
            dbContext.Portfolio.Add(portfolio);
            dbContext.SaveChanges();
            return portfolio;
        }

        public Portfolio DeletePortfolio(int id)
        {
            var result = dbContext.Portfolio.Find(id);
            dbContext.Portfolio.Remove(result);
            dbContext.SaveChanges();
            return result;
        }

        public IEnumerable<Portfolio> GetPortfolio()
        {
            return dbContext.Portfolio.ToList();
        }

        public Portfolio UpdatePortfolio(Portfolio portfolio)
        {
            dbContext.Entry(portfolio).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return portfolio;
        }
    }
}
