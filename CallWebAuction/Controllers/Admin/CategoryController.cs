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
    public class CategoryController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44331/api");
        HttpClient client;

        public CategoryController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            List<Category> cateModel = new List<Category>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/category").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                cateModel = JsonConvert.DeserializeObject<List<Category>>(data);
            }
            return View(cateModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category cate)
        {
            string data = JsonConvert.SerializeObject(cate);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/category", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }
    }
}
