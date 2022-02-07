using CryptoPricesReader.Data.Enums;
using CryptoPricesReader.Data.Models.Responses;
using CryptoPricesReader.NomicsAPI;
using CryptoPricesReader.Utilities.Helpers;

namespace CryptoPricesReader.Test
{
    public class CryptoPricesTestReader
    {
        public static async Task Main()
        {
            await Run();
        }

        public static async Task Run()
        {
            var api = new ApiConnect(Console.ReadLine());

            string[] queryParams = new string[2];
            queryParams[0] = "ids=BTC";

            var response = await api.SendRequest(QueryType.CurrenciesTicker, queryParams);

            Console.WriteLine(response);

            var parse = NomicsApiHelpers.ParseJson<List<CurrenciesTicker>>(response);

            var client = new HttpClient();
            var imageText = await client.GetStringAsync(parse.FirstOrDefault().LogoUrl);

            Console.WriteLine(imageText);

        }
    }
}

