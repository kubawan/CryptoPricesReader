using System.Text.Json.Serialization;


namespace CryptoPricesReader.Data.Models.Responses
{
    public class CurrenciesTicker
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("price")]
        public string? Price { get; set; }

        [JsonPropertyName("price_date")]
        public DateTime? PriceDate { get; set; }

        [JsonPropertyName("price_timestamp")]
        public DateTime? PriceTimestamp { get; set; }

        [JsonPropertyName("circulating_supply")]
        public string? CirculatingSupply { get; set; }

        [JsonPropertyName("max_supply")]
        public string? MaxSupply { get; set; }

        [JsonPropertyName("market_cap")]
        public string? MarketCap { get; set; }

        [JsonPropertyName("market_cap_dominance")]
        public string? MarketCapDominance { get; set; }

        [JsonPropertyName("num_exchanges")]
        public string? NumExchanges { get; set; }

        [JsonPropertyName("num_pairs")]
        public string? NumPairs { get; set; }

        [JsonPropertyName("num_pairs_unmapped")]
        public string? NumPairsUnmapped { get; set; }

        [JsonPropertyName("first_candle")]
        public DateTime? FirstCandle { get; set; }

        [JsonPropertyName("first_trade")]
        public DateTime? FirstTrade { get; set; }

        [JsonPropertyName("first_order_book")]
        public DateTime? FirstOrderBook { get; set; }

        [JsonPropertyName("rank")]
        public string? Rank { get; set; }

        [JsonPropertyName("rank_delta")]
        public string? RankDelta { get; set; }

        [JsonPropertyName("high")]
        public string? High { get; set; }

        [JsonPropertyName("high_timestamp")]
        public DateTime? HighTimestamp { get; set; }

        [JsonPropertyName("1h")]
        public IntervalTicker? H1 { get; set; }

        [JsonPropertyName("1d")]
        public IntervalTicker? D1 { get; set; }

        [JsonPropertyName("7d")]
        public IntervalTicker? D7 { get; set; }

        [JsonPropertyName("30d")]
        public IntervalTicker? D30 { get; set; }

        [JsonPropertyName("365d")]
        public IntervalTicker? D365 { get; set; }

        [JsonPropertyName("ytd")]
        public IntervalTicker? Ytd { get; set; }
    }
}
