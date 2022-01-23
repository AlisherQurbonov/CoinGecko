using Newtonsoft.Json;

namespace cripto.Entities.Response.Coins;

   public class MarketChartById
    {
        [JsonProperty("prices")]
        public decimal?[][] Prices { get; set; }

        [JsonProperty("market_caps")]
        public decimal?[][] MarketCaps { get; set; }

        [JsonProperty("total_volumes")]
        public decimal?[][] TotalVolumes { get; set; }
    }