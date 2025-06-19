//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
//using System.Net.Http.Headers;

//namespace SiliconApp.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly HttpClient _http;
//        public HomeController(HttpClient http)
//        {
//            _http = http;
//        }



//        public async Task<IActionResult> Index()
//        {
          
//            var tokenResponse = await _http.SendAsync(new HttpRequestMessage
//            {
//                RequestUri = new Uri("https://localhost:7086/api/auth"),
//                Method = HttpMethod.Post
//            }) ; 

//            if(tokenResponse.IsSuccessStatusCode)
//            {

//                HttpContext.Session.SetString("token", await tokenResponse.Content.ReadAsStringAsync());
               
//            }

//            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));




         
//            var response = await _http.GetAsync("https://localhost:7086/api/Course");
//            if (response.IsSuccessStatusCode)
//            {
//                var json = await response.Content.ReadAsStringAsync();
//                var data = JsonConvert.DeserializeObject<List<string>>(json);
//                return View(data);
//            }


//            return View(new List<string>());
//        }
//    }
//}
