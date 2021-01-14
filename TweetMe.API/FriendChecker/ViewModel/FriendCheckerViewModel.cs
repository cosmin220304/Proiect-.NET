using System.Collections.Generic;

namespace FriendChecker.ViewModel
{
    public class FriendCheckerViewModel
    {
        public IList<FriendViewModel> HappyFriends { get; set; }
        public IList<FriendViewModel> SadFriends { get; set; }
    }
}
