using lab8.Services.Interfaces;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace lab8.Services.Implementations
{
    public class HttpService : IHttpService
    {
        private const string ApplicationJson = "application/json";

        private const string SetCoockie = "Set-Cookie";

        public IEnumerable<string>? Cookies { get; set; }

        public T Send<T, K>(HttpMethod httpMethod, string requestUri, K requestModel, Dictionary<string, IEnumerable<string>>? headers = null)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationJson));

            var request = new HttpRequestMessage
            {
                Content = new StringContent(JsonConvert.SerializeObject(requestModel), Encoding.UTF8, ApplicationJson),
                Method = httpMethod,
                RequestUri = new Uri(requestUri),
            };

            AddHeaders(request, headers);

            HttpResponseMessage response = client.Send(request);

            Cookies = response.Headers.SingleOrDefault(header => header.Key == SetCoockie).Value;

            string jsonString = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public T Send<T>(HttpMethod httpMethod, string requestUri, Dictionary<string, IEnumerable<string>>? headers = null)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationJson));

            var request = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri(requestUri),
            };

            AddHeaders(request, headers);

            HttpResponseMessage response = client.Send(request);

            Cookies = response.Headers.SingleOrDefault(header => header.Key == SetCoockie).Value;

            string jsonString = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public HttpResponseMessage Send<T>(HttpMethod httpMethod, string requestUri, T model, Dictionary<string, IEnumerable<string>>? headers = null)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationJson));

            var request = new HttpRequestMessage
            {
                Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, ApplicationJson),
                Method = httpMethod,
                RequestUri = new Uri(requestUri),
            };

            AddHeaders(request, headers);

            HttpResponseMessage response = client.Send(request);

            Cookies = response.Headers.SingleOrDefault(header => header.Key == SetCoockie).Value;

            return response;
        }

        public HttpResponseMessage Send(HttpMethod httpMethod, string requestUri, Dictionary<string, IEnumerable<string>>? headers = null)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationJson));

            var request = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri(requestUri),
            };

            AddHeaders(request, headers);

            HttpResponseMessage response = client.Send(request);

            Cookies = response.Headers.SingleOrDefault(header => header.Key == SetCoockie).Value;

            return response;
        }

        private static void AddHeaders(HttpRequestMessage request, Dictionary<string, IEnumerable<string>>? headers = null)
        {
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
        }
    }
}
