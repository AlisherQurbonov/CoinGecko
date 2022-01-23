using Newtonsoft.Json;

namespace cripto.Entities.Response;

 public class Ping
    {
        [JsonProperty("gecko_says")]
        public string GeckoSays { get; set; }
    }