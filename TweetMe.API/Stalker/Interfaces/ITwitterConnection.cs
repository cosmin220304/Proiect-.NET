using System.Net.Http;

namespace Stalker.Interfaces
{
    public interface ITwitterConnection
    {
        HttpClient GetTwitterClient();
    }
}