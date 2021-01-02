using Microsoft.AspNetCore.Mvc;
using ProfileFinder.Data;
using System.Linq;

namespace ProfileFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileFinderAPI : ControllerBase
    {
        public DataContext _context { get; set; }
        public ProfileFinderAPI(DataContext context)
        {
            _context = context;
        }

        [HttpPatch("{user_username}")]
        public SearchedProfiles UpdateSearchedTimes(string user_username)
        {
            var searchedProfile = _context.SearchedProfiles.Select(user => user).Where(user => user.Username == user_username).FirstOrDefault();

            if (searchedProfile != null)
            {
                int nrOfSearched = searchedProfile.Searched;
                searchedProfile.Update(nrOfSearched + 1);
                _context.SaveChanges();
            }
            else
            {
                int nrOfSearched = 1;
                searchedProfile = new SearchedProfiles()
                {
                    Searched = nrOfSearched,
                    Username = user_username
                };

                _context.SearchedProfiles.Add(searchedProfile);
                _context.SaveChanges();
            }

            return searchedProfile;
        }
    }
}
