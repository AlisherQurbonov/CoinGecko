
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace cripto.Entities.Response.Exchanges;

  public class TickerByExchangeId
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }
    }