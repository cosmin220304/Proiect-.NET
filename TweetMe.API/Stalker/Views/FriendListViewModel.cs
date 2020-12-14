using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stalker.Views
{
    public class FriendListViewModel
    {
        [JsonProperty("users")]
        public List<UserViewModel> Users { get; set; }
    }
}
