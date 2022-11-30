using LearnEnglish.Desktop.Interfaces;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace LearnEnglish.Desktop.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            var request = CreateRequest(HttpMethod.Get, uri, null);
            return await SendRequestAsync<T>(request);
        }

        public async Task<bool> PostAsync(string uri, object value)
        {
            var response = await SendRequestAsync(CreateRequest(HttpMethod.Post, uri, value));
            return response.IsSuccessStatusCode;
        }


        private async Task<T> SendRequestAsync<T>(HttpRequestMessage request)
        {
            var response = await SendRequestAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<T>();
            }

            return default;
        }

        private async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request)
        {
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            return await _httpClient.SendAsync(request);
        }

        private HttpRequestMessage CreateRequest(HttpMethod method, string uri, object value)
        {
            var request = new HttpRequestMessage(method, uri);
            if (value != null)
            {
                request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            }
            return request;
        }
    }
}
