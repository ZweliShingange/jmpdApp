using JmpdAppApi.Common.Dto;
using JmpdAppApi.DataAccess.Models;

namespace JmpdAppApi.Common.Helpers
{
    public static class VerifyService
    {
        public static bool VerifyUserPassword(TrafficOfficial trafficOfficial, string officialSignInPassword)
        {
            if (VerifyPassword(trafficOfficial.Password,officialSignInPassword))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private static bool VerifyPassword(string password, string userPassword)
        {
            //addApsswordHashingret
            return true;
        }
    }
}
