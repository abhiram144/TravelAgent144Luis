using SimpleEchoBot.Data_Helpers;
using SimpleEchoBot.Data_Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

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