using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OxyApi
{
    class Program
    {
        static async Task Main()
        {
            const string Username = "YOUR_USERNAME";
            const string Password = "YOUR_PASSWORD";

            var parameters = new Dictionary<string, string>()
            {
                { "source", "universal_ecommerce" },
                { "url", "https://shop.mango.com/lt/men?gad_source=1&gclid=cjwkcaiaungubhakeiwagid4akiddksf_zk7lumx_nottzazyf1w3isfgemq2iutuocip9yuq_qmzhochoyqavd_bwe&gclsrc=aw.ds" },
            };


            var client = new HttpClient();

            Uri baseUri = new Uri("https://realtime.oxylabs.io");
            client.BaseAddress = baseUri;

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/v1/queries");
            requestMessage.Content = JsonContent.Create(parameters);

            var authenticationString = $"{Username}:{Password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(authenticationString));
            requestMessage.Headers.Add("Authorization", "Basic " + base64EncodedAuthenticationString);

            var response = await client.SendAsync(requestMessage);
            var contents = await response.Content.ReadAsStringAsync();

            Console.WriteLine(contents);
        }
    }
}