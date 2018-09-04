using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Models;
using Newtonsoft.Json;

namespace DemoApp.Services
{
    public class RestService : IRestService
    {
        HttpClient client;

        public RootObject Items { get; private set; }

        public RestService()
        {
            //var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
            //var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            client = new HttpClient();
           // client.MaxResponseContentBufferSize = 256000;
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
        }

        public async Task<RootObject> RefreshDataAsync()
        {
            Items = new RootObject();

            string RestUrl = "https://randomuser.me/api/";
            var uri = new Uri(string.Format(RestUrl, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {

                    var content = await response.Content.ReadAsStringAsync();
                    RootObject rootObject = new RootObject();
                    Items = JsonConvert.DeserializeObject<RootObject>(content);
                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return Items;
        }

    }
}
