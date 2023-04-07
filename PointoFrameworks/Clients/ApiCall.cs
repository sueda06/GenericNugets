using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;

namespace Clients
{
    public class ApiCall<T> where T : class 
    {

        public static async Task<List<T>> GetAsync(string url,string contentType)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(contentType));

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            List<T> contributors = JsonConvert.DeserializeObject<List<T>>(resp);
            return contributors;
        }
        public static async Task<T> PostAsync(string url, string contentType, T data)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(contentType));

            var json = JsonConvert.SerializeObject(data);
            var newdata = new StringContent(json, Encoding.UTF8, contentType);
            HttpResponseMessage response = await client.PostAsync(url,newdata);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();

            T contributor = JsonConvert.DeserializeObject<T>(result);
            return contributor;
        }
    }
}
