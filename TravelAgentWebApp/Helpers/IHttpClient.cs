using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Travel_Website.Common;

namespace Travel_Website.Helpers
{
    public interface IHttpClient 
    {
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri);
        Task<HttpResponseMessage> DeleteAsync(string requestUri);
        Task<HttpResponseMessage> GetAsync(string uri);
        Task<HttpResponseMessage> PostAsync(string uri, FormUrlEncodedContent formContent);

        Task<HttpResponseMessage> PostAsync(string uri, StringContent formContent);
        Task<HttpResponseMessage> PostAsync(string uri, MultipartFormDataContent formContent);
        Task<HttpResponseMessage> PutAsync(string uri, MultipartFormDataContent formContent);

        //Task<HttpResponseMessage> PostAsync(string uri, FileUploadRequest file);
        Task<HttpResponseMessage> PutAsync();
        void Initialize(string uri, bool useSSL);

        void Initialize(string token);

        void Initialize(string uri, string id, string secret, Enums.AuthenticationScheme authenticationScheme);

        void Initialize(string uri, string token);

        void Initialize(string uri, bool usessl, string token);

    }
}
