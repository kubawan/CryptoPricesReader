using CryptoPricesReader.NomicsAPI.Enums;
using System.Text;

namespace CryptoPricesReader.NomicsAPI.Helpers
{
    public static class NomicsApiHelpers
    {
        public static string GetQueryFromQueryType(QueryType queryType)
        {
            switch (queryType)
            {
                case QueryType.CurrenciesTicker:
                    return "/currencies/ticker";

                default:
                    return "/";
            }
        }

        public static string BuildQueryParams(string[] queryParmas)
        {
            var sb = new StringBuilder();

            foreach (var param in queryParmas)
            {
                sb.Append(param);
                sb.Append("&");
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}
