using CryptoPricesReader.Data.Enums;
using CryptoPricesReader.NomicsAPI;

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
            var api = new ApiConnect();

            string[] queryParams = new string[2];

            queryParams[0] = "key=your_api_key";
            queryParams[1] = "ids=BTC";

            var response = await api.SendRequest(QueryType.CurrenciesTicker, queryParams);

            Console.WriteLine(response);
        }
    }
}

