using Newtonsoft.Json;

namespace cripto.Entities.Response.Events;
 public partial class EventTypes
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }

        [JsonProperty("count")]
        public long? Count { get; set; }
    }