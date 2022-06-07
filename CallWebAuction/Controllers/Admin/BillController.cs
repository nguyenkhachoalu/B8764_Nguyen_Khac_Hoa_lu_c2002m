using CallWebAuction.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CallWebAuction.Controllers.Admin
{
    public class BillController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44331/api");
        HttpClient client;

        public BillController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            List<Bill> billModel = new List<Bill>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/bill").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                billModel = JsonConvert.DeserializeObject<List<Bill>>(data);
            }
            return View(billModel);
        }
    }
}
