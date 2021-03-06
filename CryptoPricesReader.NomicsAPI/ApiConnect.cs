using CryptoPricesReader.Data.Enums;
using CryptoPricesReader.Utilities;
using CryptoPricesReader.Utilities.Helpers;
using System.Net.Http.Headers;
using System.Text;

namespace CryptoPricesReader.NomicsAPI
{
    public class ApiConnect
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        private const string ApiAddress = "https://api.nomics.com/v1";
        private string ApiKey { get; set; }

        public ApiConnect()
        {

        }

        public void SetApiKey(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public async Task<string> SendRequest(QueryType queryType, string[] queryParams)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            Logger.LogInfoToFile($"ApiCalls", $"GET Request: {QueryBuilder(queryType, queryParams)}");
            var response = await _httpClient.GetStringAsync(QueryBuilder(queryType, queryParams));
            
            Logger.LogInfoToFile($"ApiCalls", $"GET Response received!");
            return response;
        }

        private string QueryBuilder(QueryType queryType, string[] queryParams)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(ApiAddress);
            stringBuilder.Append(NomicsApiHelpers.GetQueryFromQueryType(queryType));
            stringBuilder.Append($"?key={ApiKey}");
            stringBuilder.Append(NomicsApiHelpers.BuildQueryParams(queryParams));

            return stringBuilder.ToString(); ;
        }
    }
}