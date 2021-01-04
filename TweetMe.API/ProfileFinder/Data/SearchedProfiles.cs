namespace ProfileFinder.Data
{
    public class SearchedProfiles
    {
        public SearchedProfiles()
        {

        }
        public int ID { get; set;}
        public string Username { get; set; }
        public int Searched { get; set; }
        public void Update(int searched)
        {
            Searched = searched;
        }
    }

   
}
