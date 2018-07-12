using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Website.Common
{
    public class BusinessConstants
    {
        public const string GoibiboAuthParameter = "&app_id={app_id}&app_key={app_key}&format={format}";
        public const string GoibiboBusSearchApi = "/api/bus/search/?source={0}&destination={1}&dateofdeparture={2}";
    }
}