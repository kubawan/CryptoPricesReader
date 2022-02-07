using System.Text.Json.Serialization;

namespace CryptoPricesReader.Data.Models.Responses
{
    public class IntervalTicker
    {
        [JsonPropertyName("volume")]
        public string Volume { get; set; }

        [JsonPropertyName("price_change")]
        public string PriceChange { get; set; }

        [JsonPropertyName("price_change_pct")]
        public string PriceChangePct { get; set; }

        [JsonPropertyName("volume_change")]
        public string VolumeChange { get; set; }

        [JsonPropertyName("volume_change_pct")]
        public string VolumeChangePct { get; set; }

        [JsonPropertyName("market_cap_change")]
        public string MarketCapChange { get; set; }

        [JsonPropertyName("market_cap_change_pct")]
        public string MarketCapChangePct { get; set; }
    }
}
