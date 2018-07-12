using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Website.Data_Helpers;

namespace Travel_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string appId = ConfigurationManager.AppSettings["GoibiboAppId"] as string;
            //string appSecret = ConfigurationManager.AppSettings["GoibiboAppKey"] as string;
            //string responseFormat = ConfigurationManager.AppSettings["GoibiboResponseFormat"] as string;
            //string goibiboApiUri = ConfigurationManager.AppSettings["GoibiboApiUri"] as string;
            //var searchHelper = new GoibiboBusSearchHelper(appId, appSecret, goibiboApiUri, responseFormat);
            //searchHelper.GetBusDetails("Hyderabad", "Vijayawada", DateTime.Now.ToString("yyyyMMdd"));
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}