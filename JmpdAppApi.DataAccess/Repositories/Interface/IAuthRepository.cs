using JmpdAppApi.DataAccess.Models;

namespace JmpdAppApi.DataAccess.Repositories.Interface
{
    public interface IAuthRepository
    {
        TrafficOfficial GetUser(string userOfficialNumber);
    }
}
