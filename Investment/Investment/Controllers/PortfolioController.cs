using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investment.IServices;
using Investment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Investment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService portfolioService;
        public PortfolioController(IPortfolioService portfolio)
        {
            portfolioService = portfolio;
        }
        [HttpGet]
        public IEnumerable<Portfolio> GetPortfolio()
        {
            return portfolioService.GetPortfolio();
        }
        [HttpPost]
        public Portfolio AddPortfolio(Portfolio por)
        {
            return portfolioService.AddPortfolio(por);
        }
        [HttpPut]
        public Portfolio EditPortfolio(Portfolio por)
        {
            return portfolioService.UpdatePortfolio(por);
        }
        [HttpDelete]
        public Portfolio DeletePortfolio(int id)
        {
            return portfolioService.DeletePortfolio(id);
        }
    }
}
