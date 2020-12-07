using Microsoft.AspNetCore.Components.Forms;
using System;

namespace TweetMeFront.Pages
{
    partial class Search
    {
        private string search = "";
        private string oldSearch = "";
        public void initSearch()
        {
            search = "";
        }
        public void startSearch()
        {
            Console.WriteLine(search);
            oldSearch = search;
            search = "";
        }
    }
}
