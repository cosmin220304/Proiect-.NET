using Newtonsoft.Json;
using System.Text.Json;

namespace Stalker.Views
{
    public class UserViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_image_url_https")]
        public string ImageUrl { get; set; }
    }
}
