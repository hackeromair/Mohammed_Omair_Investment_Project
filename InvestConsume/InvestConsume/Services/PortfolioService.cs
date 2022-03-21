using InvestConsume.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;


namespace InvestConsume.Services
{
    public class PortfolioService : IPortfolioService
    {


        public async Task<List<Portfolio>> GetPortfolio()
        {
            var portfoliolist = new List<Portfolio>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44390/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync("api/Portfolio/");
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;
                    portfoliolist = JsonConvert.DeserializeObject<List<Portfolio>>(readTask);
                    return portfoliolist;
                }
            }
            return portfoliolist;
        }

        public async Task<bool> SavePortfolio(Portfolio portfolio)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44390/");
                client.DefaultRequestHeaders.Clear();
                string jsonData = JsonConvert.SerializeObject(portfolio);

                // File.WriteAllText(tmpfile, JsonConvert.SerializeObject(current), Encoding.UTF8);

                var content = new StringContent(jsonData, UnicodeEncoding.UTF8, "application/json");



                var response = await client.PostAsync("api/Portfolio", content);
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;

                    var result = JsonConvert.DeserializeObject<bool>(readTask);

                    return result;
                }
            }
            return false;
        }
        
    }
}

