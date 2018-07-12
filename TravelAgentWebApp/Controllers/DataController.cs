using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Website.Data_Helpers;
using Travel_Website.Repository;

namespace Travel_Website.Controllers
{
    public class DataController : Controller
    {
        BusSearch busRepo; 
        public DataController()
        {

        }
        // GET: Data
        [HttpPost]
        public ActionResult BusSearch(string from, string to, DateTime date)
        {
            //string appId = ConfigurationManager.AppSettings["GoibiboAppId"] as string;
            //string appSecret = ConfigurationManager.AppSettings["GoibiboAppKey"] as string;
            //string responseFormat = ConfigurationManager.AppSettings["GoibiboResponseFormat"] as string;
            //string goibiboApiUri = ConfigurationManager.AppSettings["GoibiboApiUri"] as string;
            //var searchHelper = new GoibiboBusSearchHelper(appId, appSecret, goibiboApiUri, responseFormat);
            //var details = searchHelper.GetBusDetails("Hyderabad", "Vijayawada", DateTime.Now.ToString("yyyyMMdd"));
            busRepo = new Repository.BusSearch();
            var details = busRepo.SearchBusses(from, to, date);
            return View();
            //return JsonConvert.SerializeObject(details);
        }
    }
}