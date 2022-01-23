
using CoinGecko.Entities.Response.Shared;
using Newtonsoft.Json;

namespace cripto.Entities.Response.Coins;

  public class TickerById
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tickers")]
        public Ticker[] Tickers { get; set; }
    }