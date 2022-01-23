using Newtonsoft.Json;

namespace cripto.Entities.Response.Coins;

  public class SparklineIn7D
    {
        [JsonProperty("price")]
        public decimal[] Price { get; set; }
    }