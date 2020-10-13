using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CodeManageMent.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CodeManageMent.Controllers
{
    public class SteamController : Controller
    {
        private readonly HttpClient _httpClient;
        public SteamController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IActionResult> GetSteamsIndex()
        {
            HttpResponseMessage result = await _httpClient.GetAsync("https://steam.seewang.me/api");
            IEnumerable<SteamModel> option =  result.Content.ReadAsAsync<IEnumerable<SteamModel>>().Result;
            return View(option);

        }


    }   
}
