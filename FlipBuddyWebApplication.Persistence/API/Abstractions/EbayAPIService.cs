using FlipBuddyWebApplication.Domain.Constants;
using FlipBuddyWebApplication.Domain.Models.Ebay.EbayToken.Responses.Token;
using FlipBuddyWebApplication.Domain.Models.Ebay.GetCategories.Response;
using FlipBuddyWebApplication.Domain.Models.Ebay.GeteBAyDetails.Responses.Root;
using FlipBuddyWebApplication.Domain.Models.Ebay.GetItemAspectsForCategory.Response;
using FlipBuddyWebApplication.Persistence.Factories;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Xml.Serialization;

namespace FlipBuddyWebApplication.Persistence.API.Abstractions
{
	public abstract class EbayAPIService
	{
		private readonly ClientFactory _clientFactory;
		public EbayAPIService(ClientFactory clientFactory) => _clientFactory = clientFactory;

		#region GetEbayDetails
		public async Task<GeteBayDetailsResponse> GetEbayDetails(string detail, string token)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage(HttpMethod.Post, "https://api.sandbox.ebay.com/ws/api.dll");

			// Set necessary headers
			request.Headers.Add("X-EBAY-API-SITEID", "0");
			request.Headers.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "967");
			request.Headers.Add("X-EBAY-API-CALL-NAME", "GeteBayDetails");
			request.Headers.Add("X-EBAY-API-IAF-TOKEN", token);  // Replace with your actual token

			// Define XML content with UTF-8 encoding
			var xmlContent = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
							 "<GeteBayDetailsRequest xmlns=\"urn:ebay:apis:eBLBaseComponents\">\r\n" +
							 "    <ErrorLanguage>en_US</ErrorLanguage>\r\n" +
							 "    <WarningLevel>High</WarningLevel>\r\n" +
							$"    <DetailName>{detail}</DetailName>\r\n" +
							 "</GeteBayDetailsRequest>";

			var content = new StringContent(xmlContent, Encoding.UTF8, "application/xml");
			request.Content = content;

			// Send the request and check response
			var response = await client.SendAsync(request);
			response.EnsureSuccessStatusCode();

			var xmlString = (await response.Content.ReadAsStringAsync());

			XmlSerializer serializer = new XmlSerializer(typeof(GeteBayDetailsResponse));

			using (StringReader reader = new StringReader(xmlString))
			{
				GeteBayDetailsResponse result = (GeteBayDetailsResponse)serializer.Deserialize(reader);

				return result;
			}

		}

		#endregion

		#region GetEbayOAuthToken

		public async Task<string> EbayAuthorizationExchange(string clientId, string clientSecret)
		{

			var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));

			using (var client = new HttpClient())
			{
				var request = new HttpRequestMessage(HttpMethod.Post, "https://api.sandbox.ebay.com/identity/v1/oauth2/token");

				// Set headers
				request.Headers.Add("Authorization", $"Basic {credentials}");
				request.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");

				// Send the request
				var response = await client.SendAsync(request);

				// Handle response
				if (response.IsSuccessStatusCode)
				{
					var jsonResponse = await response.Content.ReadAsStringAsync();
					var theresponsestring = "Response JSON: " + jsonResponse;
					Hidden.TestUserToken = response.Content.ReadFromJsonAsync<TokenResponse>().Result.access_token.ToString();
					return Hidden.TestUserToken;
				}
				else
				{
					Console.WriteLine("Error: " + response.ReasonPhrase);
					return null;
				}
			}
		}

		public async Task<TokenResponse> GetOAuthTokenAsync(string authorizationCode)
		{
			using var _httpClient = new HttpClient();

			var clientString = Hidden.ClientId + ":" + Hidden.ClientSecret;
			byte[] clientEncode = Encoding.UTF8.GetBytes(clientString);
			var credentials = "Basic " + System.Convert.ToBase64String(clientEncode);

			HttpWebRequest request = WebRequest.Create("https://api.sandbox.ebay.com/identity/v1/oauth2/token") as HttpWebRequest;

			request.Method = "POST";
			request.ContentType = "application/x-www-form-urlencoded";
			request.Headers.Add(HttpRequestHeader.Authorization, credentials);

			var codeEncoded = authorizationCode;

			var body = "grant_type=authorization_code&code=" + codeEncoded + "&redirect_uri=" + "Jalen_Ashanti-JalenAsh-FlipBu-uxjjvf";

			byte[] formData = Encoding.UTF8.GetBytes(body);
			request.ContentLength = formData.Length;

			using (Stream post = request.GetRequestStream())
			{
				post.Write(formData, 0, formData.Length);
			}

			string resultstring = null;

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				StreamReader reader = new StreamReader(response.GetResponseStream());
				resultstring = reader.ReadToEnd();
			}

			var result = JsonConvert.DeserializeObject<TokenResponse>(resultstring);

			return result;
		}

		#endregion

		#region GetCategories
		public async Task<GetCategoriesResponse> GetEbayCategories(string token)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage(HttpMethod.Post, "https://api.sandbox.ebay.com/ws/api.dll");

			// Set necessary headers
			request.Headers.Add("X-EBAY-API-SITEID", "0");
			request.Headers.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "967");
			request.Headers.Add("X-EBAY-API-CALL-NAME", "GetCategories");
			request.Headers.Add("X-EBAY-API-IAF-TOKEN", token);  // Replace with your actual token

			// Define XML content with UTF-8 encoding
			var xmlContent = $@"<?xml version=""1.0"" encoding=""utf-8""?>
                                <GetCategoriesRequest xmlns=""urn:ebay:apis:eBLBaseComponents"">    
	                                <ErrorLanguage>en_US</ErrorLanguage>
	                                <WarningLevel>High</WarningLevel>
                                    <!--Ensure that site ID, in the Header, is set to the site you want-->
                            <DetailLevel>ReturnAll</DetailLevel>
                            <ViewAllNodes>true</ViewAllNodes>
                            </GetCategoriesRequest> ";

			var content = new StringContent(xmlContent, Encoding.UTF8, "application/xml");
			request.Content = content;

			// Send the request and check response
			var response = await client.SendAsync(request);
			response.EnsureSuccessStatusCode();

			var xmlString = (await response.Content.ReadAsStringAsync());

			XmlSerializer serializer = new XmlSerializer(typeof(GetCategoriesResponse), "urn:ebay:apis:eBLBaseComponents");

			using (StringReader reader = new StringReader(xmlString))
			{
				GetCategoriesResponse result = (GetCategoriesResponse)serializer.Deserialize(reader);

				return result;
			}

		}
		#endregion

		#region GetEbayCategorySpecifics
		public async Task<Aspects> GetItemAspectsForCategory(string token, int? categoryId)
		{
			if (categoryId == null)
				throw new ArgumentNullException(nameof(categoryId), "Category ID cannot be null.");

			using var client = new HttpClient();
			client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

			var url = $"https://api.sandbox.ebay.com/commerce/taxonomy/v1/category_tree/0/get_item_aspects_for_category?category_id={categoryId}";
			var response = await client.GetAsync(url);

			if (!response.IsSuccessStatusCode)
			{
				var errorContent = await response.Content.ReadAsStringAsync();
				throw new HttpRequestException($"Error: {response.StatusCode}. Details: {errorContent}");
			}

			var responseString = await response.Content.ReadAsStringAsync();
			Aspects aspects = JsonConvert.DeserializeObject<Aspects>(responseString);

			return aspects;
		}
		#endregion
	}
}
