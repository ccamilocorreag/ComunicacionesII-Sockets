using Comunes.Dto;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Web.ClienteHttp
{
    public static class ClienteHttpcontents<T> where T : class
    {
        static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:28434/"),

        };

        public static T Create(string apiName, T content)
        {
            CreateHeader();
            var response = client.PostAsJsonAsync($"api/{apiName}", content).Result;
            return response.Content.ReadAsAsync<T>().Result;
        }

        public static IEnumerable<T> GetAll(string apiName)
        {
            CreateHeader();
            IEnumerable<T> content = null;
            HttpResponseMessage response = client.GetAsync($"api/{apiName}").Result;
            if (response.IsSuccessStatusCode)
            {
                content = response.Content.ReadAsAsync<IEnumerable<T>>().Result;
            }
            return content;
        }

        public static T GetById(string apiName, int id)
        {
            CreateHeader();
            T content = null;
            HttpResponseMessage response = client.GetAsync($"api/{apiName}/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                content = response.Content.ReadAsAsync<T>().Result;
            }
            return content;
        }

        public static T Update(string apiName, int id, T content)
        {
            CreateHeader();
            HttpResponseMessage response =  client.PutAsJsonAsync($"api/{apiName}/{id}", content).Result;
            response.EnsureSuccessStatusCode();

            content =  response.Content.ReadAsAsync<T>().Result;
            return content;
        }

        public static HttpStatusCode Delete(string apiName, string id)
        {
            CreateHeader();
            HttpResponseMessage response = client.DeleteAsync($"api/{apiName}/{id}").Result;
            return response.StatusCode;
        }

        static void CreateHeader()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}