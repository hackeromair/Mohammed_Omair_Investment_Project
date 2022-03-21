using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestConsume.Models;
using InvestConsume.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvestConsume.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService portfolioService;
        public PortfolioController(IPortfolioService porServices)
        {
            portfolioService = porServices;
        }
        [Authorize]
        public async Task<IActionResult> List()
        {
            var list = await portfolioService.GetPortfolio();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        public async Task<IActionResult> Create(Portfolio portfolio)
        {
            bool response = await portfolioService.SavePortfolio(portfolio);
            return RedirectToAction("List");
        }
        

    }
}
