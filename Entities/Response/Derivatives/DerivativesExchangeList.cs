using Newtonsoft.Json;

namespace cripto.Entities.Response.Derivatives;

  public class DerivativesExchangesList
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }