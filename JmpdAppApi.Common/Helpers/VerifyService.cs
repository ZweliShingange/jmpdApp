using JmpdAppApi.Common.Dto;
using JmpdAppApi.DataAccess.Models;

namespace JmpdAppApi.Common.Helpers
{
    public static class VerifyService
    {
        public static  VerifyUserPassword(string trafficOfficialPassword, string officialSignInPassword)
        {
            if (VerifyPassword(trafficOfficialPassword,officialSignInPassword))
            {
                return Result<LoggedInOfficialDto>.Success(offi);
            }
            else 
            {
                return Result<LoggedInOfficialDto>.Failure("Password is incorrect");
            }
        }

        private static bool VerifyPassword(string password, string userPassword)
        {
            //addApsswordHashingret
            return true;
        }
    }
}
