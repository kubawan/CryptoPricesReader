using CryptoPricesReader.Data.Enums;
using CryptoPricesReader.Data.Models.Responses;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

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

        public static T ParseJson<T>(string rawData)
        {
            return JsonSerializer.Deserialize<T>(rawData);
        }

        public static async Task<Bitmap> GetImageAsync(string imageSource)
        {
            var fileFormat = imageSource.Substring(imageSource.Length - 3, 3);

            switch (fileFormat)
            {
                case "svg":
                    return await SVGConvertAsync(imageSource);
                case "jpg":
                case "png":
                case "bmp":
                    return await GetBitmapAsync(imageSource);

                default:
                    return null;
            }
        }

        private static async Task<Bitmap> SVGConvertAsync (string svgSource)
        {
            var client = new HttpClient();
            var httpResponseMessage = await client.GetStringAsync(svgSource);

            var svgDoc = Svg.SvgDocument.FromSvg<Svg.SvgDocument>(httpResponseMessage);

            return new Bitmap(svgDoc.Draw(), 64, 64);
        }

        private static async Task<Bitmap> GetBitmapAsync(string imageSource)
        {
            var client = new HttpClient();
            var httpResponseMessage = await client.GetStreamAsync(imageSource);
            var image = new Bitmap(httpResponseMessage);
            
            return new Bitmap(image, 64, 64);
        }
    }
}
