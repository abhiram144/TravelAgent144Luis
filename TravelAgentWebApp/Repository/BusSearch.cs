using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Travel_Website.Data_Helpers;
using Travel_Website.Data_Models;

namespace Travel_Website.Repository
{
    public class BusSearch
    {
        public BusSearchResult SearchBusses(string from, string to, DateTime date)
        {
            string appId = ConfigurationManager.AppSettings["GoibiboAppId"] as string;
            string appSecret = ConfigurationManager.AppSettings["GoibiboAppKey"] as string;
            string responseFormat = ConfigurationManager.AppSettings["GoibiboResponseFormat"] as string;
            string goibiboApiUri = ConfigurationManager.AppSettings["GoibiboApiUri"] as string;
            var searchHelper = new GoibiboBusSearchHelper(appId, appSecret, goibiboApiUri, responseFormat);
            var details = searchHelper.GetBusDetails("Hyderabad", "Vijayawada", DateTime.Now.ToString("yyyyMMdd"));
            return details;
        }
    }
}