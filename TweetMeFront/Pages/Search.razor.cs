using System;
using System.Net.Http.Json;

namespace TweetMeFront.Pages
{
    partial class Search
    {
        private string search = "";
        private Person person;
        private string apiUrl = "https://localhost:44303/stalker/users";

        public void initSearch()
        {
            search = "";
        }

        public async void startSearch()
        {
            apiUrl += "?username=" + search;
            Console.WriteLine(apiUrl);
            person = await Http.GetFromJsonAsync<Person>(apiUrl);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Id);
            search = "";
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public string Photo { get; set; }
        };
    }
}
