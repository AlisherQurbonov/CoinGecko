using Newtonsoft.Json;

namespace cripto.Entities.Response.Exchanges;

  public class ExchangesList
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }