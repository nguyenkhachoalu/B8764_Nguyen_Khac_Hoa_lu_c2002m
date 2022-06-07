using CallWebAuction.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CallWebAuction.Controllers.Admin
{
    public class AuctionController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44331/api");
        HttpClient client;

        public AuctionController()
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
        public IActionResult Accomplished()
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
        public IActionResult Unfinished()
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Auction auction)
        {
            string data = JsonConvert.SerializeObject(auction);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/auction", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }
    }
}
