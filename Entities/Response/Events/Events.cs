using Newtonsoft.Json;

namespace cripto.Entities.Response.Events;

   public partial class Events
    {
        [JsonProperty("data")]
        public EventData[] Data { get; set; }

        [JsonProperty("count")]
        public long? Count { get; set; }

        [JsonProperty("page")]
        public long? Page { get; set; }
    }