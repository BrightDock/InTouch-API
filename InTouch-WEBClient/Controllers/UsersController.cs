using InTouch_WEBClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace InTouch_WEBClient.Controllers
{
    public class UsersController : Controller
    {
        HttpClient client;
        //The URL of the WEB API Service
        string url = "http://localhost:51533/api/";
        // GET: Users
        public UsersController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<ActionResult> Index()
        {
            return View();
        }

        [Route("GetUsers")]
        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "users/GetUsers/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                
                var jsonSettings = new JsonSerializerSettings();
                jsonSettings.NullValueHandling = NullValueHandling.Include;
                var Users = JsonConvert.DeserializeObject<List<UserUniversity>>(responseData, jsonSettings);

                ViewBag.usersCount = responseData;

                return PartialView(Users);
            }
            return View("Error");
        }

        [Route("GetStudents")]
        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "users/GetStudents/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var jsonSettings = new JsonSerializerSettings();
                jsonSettings.NullValueHandling = NullValueHandling.Include;
                var Users = JsonConvert.DeserializeObject<List<UserGroupUniversity>>(responseData, jsonSettings);

                ViewBag.usersCount = responseData;

                return PartialView(Users);
            }
            return View("Error");
        }

        [Route("GetProfessors")]
        [HttpGet]
        public async Task<ActionResult> GetProfessors()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "users/GetProfessors/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var jsonSettings = new JsonSerializerSettings();
                jsonSettings.NullValueHandling = NullValueHandling.Include;
                var Users = JsonConvert.DeserializeObject<List<Subjecst_professors>>(responseData, jsonSettings);

                ViewBag.usersCount = responseData;

                return PartialView(Users);
            }
            return View("Error");
        }
    }
}