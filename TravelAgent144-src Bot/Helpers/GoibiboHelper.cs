using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleEchoBot.Common;
using SimpleEchoBot.Data_Models;

namespace SimpleEchoBot.Data_Helpers
{
    public class GoibiboBusSearchHelper
    {
        private string appId;
        private string appSecret;
        private string apiUri;
        private string responseFormat;
        public GoibiboBusSearchHelper(string goibiboAppId, string goibiboAppSecret, string goibiboApiUri, string responseFormat)
        {
            this.appId = goibiboAppId;
            this.appSecret = goibiboAppSecret;
            apiUri = goibiboApiUri;
            this.responseFormat = responseFormat;
        }
        public BusSearchResult GetBusDetails(string from, string to, string dateOfJourney)
        {
            BusSearchResult bussesAvailable = new BusSearchResult();
            var url = BusinessConstants.GoibiboBusSearchApi;
            url = string.Format(url, from, to, dateOfJourney);
            url = AddAuthentication(url);
            var serviceAgent = new WebApiClient(apiUri, appId, appSecret);
            using (var response = serviceAgent.GetAsync(url))
            {
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonResponse = result.Content.ReadAsStringAsync().Result;
                    bussesAvailable = JsonConvert.DeserializeObject<BusSearchResult>(jsonResponse);
                }
            }
            return bussesAvailable;
        }

        private string AddAuthentication(string url)
        {
            url += BusinessConstants.GoibiboAuthParameter;
            url = url.Replace("{app_id}", appId).Replace("{app_key}", appSecret).Replace("{format}", responseFormat);
            return url;
        }
    }
}