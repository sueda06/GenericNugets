using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PointoFrameworks.PointoFrameworks.Clients
{
    public class XMlCall<T> where T : class
    {
        public static async Task<T> GetAsync(string url, string contentType)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(contentType));

            HttpResponseMessage response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            var resp = response.Content.ReadAsStringAsync().Result;

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(resp))
            {
                T contributors = (T)serializer.Deserialize(reader);
                return contributors;
            };
        }
    }
}
