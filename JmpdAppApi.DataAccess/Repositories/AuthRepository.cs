using JmpdAppApi.DataAccess.Models;
using JmpdAppApi.DataAccess.Repositories.Interface;

namespace JmpdAppApi.DataAccess.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IDatabaseContext context;

        public AuthRepository(IDatabaseContext context)
        {
            this.context = context;
        }

        public TrafficOfficial GetUser(string userOfficialNumber)
        {
            var user = from official in this.context.TrafficOfficials
                       where official.OfficerNumber == userOfficialNumber
                       select official;

            return user.SingleOrDefault();
        }
    }
}
