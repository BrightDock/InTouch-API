using InTouch_WEBClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
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
            try
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
                return View("Error", responseMessage);
            }
            catch (Exception ex) {
                return View("Error", ex);
            }
        }

        [Route("GetStudents")]
        [HttpGet]
        public async Task<ActionResult> GetStudents(string userID = "")
        {
            try
            {
                List<string> param = new List<string>();
                foreach (var parameterKey in Request.QueryString.Keys)
                {
                    param.Add(parameterKey.ToString() + '=' + Request.Params.Get(parameterKey.ToString().ToString()));
                }
                HttpResponseMessage responseMessage = await client.GetAsync(string.Format("{0}{1}/?{2}/", url, "users/GetStudents", 
                    string.Join("&", param)));
                if (responseMessage.IsSuccessStatusCode)
                {
                    var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                    var jsonSettings = new JsonSerializerSettings();
                    jsonSettings.NullValueHandling = NullValueHandling.Include;
                    var Users = JsonConvert.DeserializeObject<List<UserGroupUniversity>>(responseData, jsonSettings);

                    ViewBag.param = Users.Count;

                    return PartialView(Users);
                }
                return View("Error", responseMessage);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        [Route("GetProfessors")]
        [HttpGet]
        public async Task<ActionResult> GetProfessors()
        {
            try
            {
                HttpResponseMessage responseMessage = await client.GetAsync(url + "users/GetProfessors/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var jsonSettings = new JsonSerializerSettings();
                jsonSettings.NullValueHandling = NullValueHandling.Include;
                var Users = JsonConvert.DeserializeObject<List<ProfessorSubjects>>(responseData, jsonSettings);

                ViewBag.usersCount = responseData;

                return PartialView(Users);
                }
                return View("Error", responseMessage);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }
    }
}