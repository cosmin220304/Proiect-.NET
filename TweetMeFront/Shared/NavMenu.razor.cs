
namespace TweetMeFront.Shared
{
    partial class NavMenu
    {
        private bool isLogged = true;
        private string logged => isLogged ? "show-nav" : "hide-nav";
        private string logoLink => isLogged ? "search" : "/";
    }
}
