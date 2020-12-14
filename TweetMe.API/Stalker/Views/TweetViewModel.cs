using Newtonsoft.Json;

namespace Stalker.Views
{
    public class TweetViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("created_at")]
        public string Data { get; set; }
    }
}
