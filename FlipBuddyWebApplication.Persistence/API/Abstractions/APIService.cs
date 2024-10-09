using FlipBuddyWebApplication.Persistence.Factories;
using Newtonsoft.Json;
using System.Text;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FlipBuddyWebApplication.Persistence.API.Abstractions
{
    public abstract class APIService : IAPIRequestInterface
    {
        private readonly ClientFactory _clientFactory;
        public APIService(ClientFactory clientFactory)
        {

            _clientFactory = clientFactory;
        }


        public async Task<TResponse> GetAPIResponse<TResponse>(string _url)
        {
            var client = ClientFactory.CreateNewClient();

            var response = await client.GetStringAsync(_url);

            var result = JsonConvert.DeserializeObject<TResponse>(response);

            return result;
        }

        public async Task<IEnumerable<TResponse>> GetListAPIResponse<TResponse>(string _url)
        {
            try
            {
                var client = ClientFactory.CreateNewClient();

                var response = await client.GetStringAsync(_url);

                var result = JsonConvert.DeserializeObject<IEnumerable<TResponse>>(response);

                return result;
            }
            catch
            {

                return new List<TResponse>();
            }
        }

        public async Task<string> PostAPIRequest(string _url, Object body)
        {

            var client = ClientFactory.CreateNewClient();

            client.BaseAddress = new Uri(_url);

            string json = JsonSerializer.Serialize(body);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("", data);
            var result = await response.Content.ReadAsStringAsync();
            client.Dispose();
            return result;
        }

        public Task<string> PutAPIRequest(string _url, Object body)
        {
            var client = ClientFactory.CreateNewClient();

            client.BaseAddress = new Uri(_url);

            string json = JsonSerializer.Serialize(body);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync("", data).Result;
            var result = response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
