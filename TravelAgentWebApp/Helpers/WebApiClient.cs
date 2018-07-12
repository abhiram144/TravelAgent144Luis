using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Travel_Website.Common;

namespace Travel_Website.Helpers
{
    public class WebApiClient : IHttpClient
    {
        private string Uri, ClientID, ClientSecret, BasicAuthHeader, Bearertoken, UserName, Password;
        private bool _useSSL = false;
        private HttpClient httpClient;
        private Enums.AuthenticationScheme authScheme;
        private string appKey;
        private string appId;
        public WebApiClient(string uri, string appId, string appKey)
        {
            this.appId = appId;
            this.appKey = appKey;
            Uri = uri;
            authScheme = Enums.AuthenticationScheme.NoAuthentication;
            CreateClient();
        }
        public void Initialize(string uri,bool useSSL)
        {
            Uri = uri;
            _useSSL = useSSL;
            authScheme = Enums.AuthenticationScheme.NoAuthentication;
            CreateClient();
        }
        public void Initialize(string token)
        {
            authScheme = Enums.AuthenticationScheme.Bearer;
            Bearertoken = token;
            CreateClient();
        }
        public void Initialize(string uri, bool useSSL, string token)
        {
            Uri = uri;
            _useSSL = useSSL;
            authScheme = Enums.AuthenticationScheme.Bearer;
            Bearertoken = token;
            CreateClient();
        }
        public void Initialize(string uri, string token)
        {
            Uri = uri;
            authScheme = Enums.AuthenticationScheme.Bearer;
            Bearertoken = token;
            CreateClient();
        }
        public void Initialize(string uri, string id, string secret, Enums.AuthenticationScheme authenticationScheme)
        {
            Uri = uri;
            if (authenticationScheme == Enums.AuthenticationScheme.ClientCredentials)
            {
                ClientID = id;
                ClientSecret = secret;
                BasicAuthHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes(ClientID + ":" + ClientSecret));
                authScheme = Enums.AuthenticationScheme.ClientCredentials;
            }
            if (authenticationScheme == Enums.AuthenticationScheme.SiteCore)
            {
                UserName = id;
                Password = secret;
                authScheme = Enums.AuthenticationScheme.SiteCore;
            }
            CreateClient();
        }
        private void CreateClient()
        {
            if (_useSSL == true)
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => { return true; };
            }
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Uri);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            switch (authScheme)
            {
                case Enums.AuthenticationScheme.ClientCredentials:
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", BasicAuthHeader);
                    break;

                case Enums.AuthenticationScheme.Bearer:
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Bearertoken);
                    break;

                case Enums.AuthenticationScheme.SiteCore:
                    httpClient.DefaultRequestHeaders.Add("X-Scitemwebapi-Username", UserName);
                    httpClient.DefaultRequestHeaders.Add("X-Scitemwebapi-Password", Password);
                    break;
            }
            //if(authScheme==AuthenticationScheme.ClientCredentials)
            //{
            //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", BasicAuthHeader);
            //}   
            //if(!string.IsNullOrEmpty(Bearertoken))
            //{
            //    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Bearertoken);
            //}

            //if (!string.IsNullOrEmpty(UserName)&& !string.IsNullOrEmpty(Password))
            //{
            //    httpClient.DefaultRequestHeaders.Add("X-Scitemwebapi-Username", UserName);
            //    httpClient.DefaultRequestHeaders.Add("X-Scitemwebapi-Password", Password);
            //}

        }

        public Task<HttpResponseMessage> DeleteAsync(string uri)
        {
            return httpClient.DeleteAsync(uri);
        }

        public Task<HttpResponseMessage> GetAsync(string uri)
        {
            return httpClient.GetAsync(uri);
        }

        public Task<HttpResponseMessage> PostAsync(string uri, FormUrlEncodedContent formContent)
        {
            return httpClient.PostAsync(uri, formContent);
        }

        public Task<HttpResponseMessage> PostAsync(string uri, MultipartFormDataContent file)
        {
            return httpClient.PostAsync(uri, file);
        }

        public Task<HttpResponseMessage> PostAsync(string uri, StringContent formContent)
        {
            return httpClient.PostAsync(uri, formContent);
        }

        public Task<HttpResponseMessage> PutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync(string uri, MultipartFormDataContent formContent)
        {
            return httpClient.PutAsync(uri, formContent);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            httpClient = null;
        }

        public Task<HttpResponseMessage> PostAsync(string uri, HttpContent formContent)
        {
            return httpClient.PostAsync(uri, formContent);
        }
    }
}
