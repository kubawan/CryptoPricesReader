using CryptoPricesReader.NomicsAPI;
using CryptoPricesReader.NomicsAPI.Enums;

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

            queryParams[0] = "key=dcbe3fde97e13ccaf561cb905378084e2ea35c65";
            queryParams[1] = "ids=BTC";

            var response = await api.SendRequest(QueryType.CurrenciesTicker, queryParams);

            Console.WriteLine(response);
        }
    }
}

