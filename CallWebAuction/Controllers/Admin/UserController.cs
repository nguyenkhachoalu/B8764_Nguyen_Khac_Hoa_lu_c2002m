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
    public class UserController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44331/api");
        HttpClient client;

        public UserController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            List<User> userModel = new List<User>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/user").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                userModel = JsonConvert.DeserializeObject<List<User>>(data);
            }
            return View(userModel);
        }
        public IActionResult ProfileUser(int id)
        {
            List<User> userModel = new List<User>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/user/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                userModel = JsonConvert.DeserializeObject<List<User>>(data);
            }
            return View(userModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", user);
            }
            HttpResponseMessage responseCheck = client.GetAsync(client.BaseAddress + "/user/" + user.UserName).Result;
            if (responseCheck.IsSuccessStatusCode)
            {
                string dataCheck = responseCheck.Content.ReadAsStringAsync().Result;
                var userCheck = JsonConvert.DeserializeObject<User>(dataCheck);
                if (userCheck != null)
                {
                    ModelState.AddModelError("UserName", "User đã tồn tại");
                    return View("Create", user);
                }
            }
            string data = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/user", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View("Create", user);
        }
        public IActionResult Edit(Guid id)
        {
            User userE = new User();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/user/getbyid/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                userE = JsonConvert.DeserializeObject<User>(data);
            }
            return View(userE);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", user);
            }
            string data = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/user/" + user.Id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Edit", user);
        }
        public IActionResult Delete(Guid id)
        {
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/user/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
