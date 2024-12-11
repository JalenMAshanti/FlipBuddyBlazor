using FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Request;
using FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPricedItem.Response;
using FlipBuddyWebApplication.Domain.Models.Ebay.AddFixedPriceItem.Response;
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

        #region GetSingleRequest
        public async Task<TResponse> GetAPIResponse<TResponse>(string _url)
        {
            var client = ClientFactory.CreateNewClient();

            var response = await client.GetStringAsync(_url);

            var result = JsonConvert.DeserializeObject<TResponse>(response);

            return result;
        }
        #endregion

        #region GetListRequest
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
        #endregion

        #region Post Requests
        public async Task<HttpResponseMessage> PostAPIRequest(string _url, Object body)
        {

            var client = ClientFactory.CreateNewClient();

            client.BaseAddress = new Uri(_url);

            string json = JsonSerializer.Serialize(body);

            var data = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync("", data);

                client.Dispose();

                return response;
            }
            catch 
            {
                HttpResponseMessage message = new HttpResponseMessage();
                message.StatusCode = System.Net.HttpStatusCode.BadRequest;
                message.Content = data;
                return message;
            }
        }

		public async Task<double> PostAPIRequestEbayListing(string _url, object body)
		{
			var client = ClientFactory.CreateNewClient();
			client.BaseAddress = new Uri(_url);

			string json = JsonSerializer.Serialize(body);
			var data = new StringContent(json, Encoding.UTF8, "application/json");

			try
			{
				// Make the POST request
				var response = await client.PostAsync("", data);

				// Ensure the response is successful, or throw an exception
				response.EnsureSuccessStatusCode();

				// Read the response content as a string
				var responseContent = await response.Content.ReadAsStringAsync();

				// Deserialize the response content to TResponse
				var result = JsonConvert.DeserializeObject<ListFixedPricedItemResponse>(responseContent);

				return result.response.ItemID;
			}
			catch
			{
				// Return a new instance of TResponse if there's an error
				return double.MinValue;
			}
			finally
			{
				// Dispose of the HttpClient
				client.Dispose();
			}
		}
		#endregion

		#region Put Request
		public async Task<HttpResponseMessage> PutAPIRequest(string _url, Object body)
        {
            var client = ClientFactory.CreateNewClient();

            client.BaseAddress = new Uri(_url);

            string json = JsonSerializer.Serialize(body);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync("", data);
            
            client.Dispose();

            return response;
        }
        #endregion

        #region Delete Request
        public async Task<HttpResponseMessage> DeleteAPIRequest(string _url) 
        {
            var client = ClientFactory.CreateNewClient();

            var result = await client.DeleteAsync(_url);

            return result;
        }
        #endregion
    }
}
