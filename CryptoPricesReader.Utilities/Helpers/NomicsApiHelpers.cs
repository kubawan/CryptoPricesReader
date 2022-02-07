using CryptoPricesReader.Data.Enums;
using System.Text;

namespace CryptoPricesReader.Utilities.Helpers
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

        public static string BuildQueryParams(string queryParmas)
        {
            return queryParmas;
        }

        public static string BuildQueryParams(string[] queryParmas)
        {
            var sb = new StringBuilder();

            foreach (var param in queryParmas)
            {
                sb.Append("&");
                sb.Append(param);
            }

            return sb.ToString();
        }
    }
}
