using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCClientApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCClientApp.Controllers
{
    public class HotelController : Controller
    {
        public static string baseUrl = "https://localhost:44319/api/Hotel/";
        public async Task<IActionResult> Index()
        {
            var hotels = await GetHotels();
            return View(hotels);
        }

        [HttpGet]
        public async Task<IEnumerable<HotelDetail>> GetHotels()
        {
            var accessToken = HttpContext.Session.GetString("JWTToken");
            var url = baseUrl;
            HttpClient client = new HttpClient();
           // client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            string jsonStr = await client.GetStringAsync(url);
            var response = JsonConvert.DeserializeObject<List<HotelDetail>>(jsonStr);
            return  response;
        }
    }
}
