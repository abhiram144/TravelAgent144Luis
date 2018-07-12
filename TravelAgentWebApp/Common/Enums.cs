using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Website.Common
{
    public class Enums
    {
        public enum AuthenticationScheme
        {
            ClientCredentials,
            Bearer,
            SiteCore,
            NoAuthentication
        }
    }
}