using CallWebAuction.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CallWebAuction.Controllers.HomeAuction
{
    public class StoreController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44331/api");
        HttpClient client;

        public StoreController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            List<Auction> auctionModel = new List<Auction>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/auction").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                auctionModel = JsonConvert.DeserializeObject<List<Auction>>(data);
            }
            return View(auctionModel);
        }
    }
}
