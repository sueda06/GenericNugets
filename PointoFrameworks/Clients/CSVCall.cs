using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
using System.Reflection;

namespace Clients
{
    public class CSVCall<T> where T : class,new() 
    {
        public static async Task<List<T>> GetAsync(string url,char seperator,string contentType)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(contentType));

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();
            List<T> list = (List<T>)CustomDeserialize(resp,seperator).ToList();
            return list;
        }
        protected static IEnumerable<T> CustomDeserialize(string csvString,char seperator)
        {
            string[] arrayLinesCsv = csvString.Split('\r','\n');
            string[] columnsName = arrayLinesCsv[0].Split(seperator);
            Type tp = typeof(T);
            PropertyInfo[] props = tp.GetProperties();
            for (int i = 1; i < arrayLinesCsv.Length - 1; i++)
            {
                if (arrayLinesCsv[i] != "")
                {
                    object instance = Activator.CreateInstance(tp);
                    string[] columnsValue = arrayLinesCsv[i].Split(seperator);
                    for (int j = 0; j < columnsValue.Length; j++)
                    {
                        PropertyInfo prop = null;
                        for (int x = 0; x < props.Length; x++)
                        {
                            if (columnsName[j] == props[x].Name.ToLower().Replace("ı","i"))
                            {
                                prop = props[x];
                            }
                            if (null != prop)
                            {
                                prop.SetValue(instance, Convert.ChangeType(columnsValue[j], Type.GetTypeCode(prop.PropertyType)), null);
                            }
                        }
                    }
                    yield return (instance as T);
                }
            }
        }
    }
}
