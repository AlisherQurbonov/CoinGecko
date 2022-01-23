using Newtonsoft.Json;

namespace cripto.Entities.Response.Coins;

  public class CoinList
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("platforms")]
        public Dictionary<string,string> Platforms { get; set; }
    }