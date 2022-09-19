using JmpdAppApi.Common;
using JmpdAppApi.Common.Dto;
using JmpdAppApi.Common.Helpers;
using JmpdAppApi.Core.Services.IServices;
using JmpdAppApi.DataAccess.Repositories.Interface;

namespace JmpdAppApi.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthRepository authRepository;

        public AuthenticationService(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }

        public Result SignInOfficial(OfficialSignInDto userOfficial)
        {
            try
            {
                var user =  authRepository.GetUser(userOfficial.Username);

                if (user != null)
                {
                     return VerifyService.VerifyUserPassword(user, userOfficial);
                }
                else 
                {
                    return Result<LoggedInOfficialDto>.Failure("No user found or username is incorrect");
                }

            }
            catch (Exception ex)
            {
                return Result.Failure(ex.Message);
            }
        }
    }
}