using JmpdAppApi.Common;
using JmpdAppApi.Common.Dto;
using JmpdAppApi.Common.Helpers;
using JmpdAppApi.Common.Mappers;
using JmpdAppApi.Core.Services.IServices;
using JmpdAppApi.DataAccess.Repositories.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace JmpdAppApi.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthRepository authRepository;

        public AuthenticationService(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }

        public Result<LoggedInOfficialDto> SignIn(OfficialSignInDto userOfficial)
        {
            try
            {
                var user =  authRepository.GetUser(userOfficial.Username);

                if (user != null)
                {
                    if (VerifyService.VerifyUserPassword(user, userOfficial.Password))
                    {
                        return Result<LoggedInOfficialDto>.Success(Mapper.MapToLoggedInOfficial(user));
                    }
                    else
                    {
                        throw new Exception("Incorrect Passsword");
                    }
                }
                else 
                {
                    throw  new Exception("No user found or username is incorrect");
                }

            }
            catch (Exception ex)
            {
                return Result<LoggedInOfficialDto>.Failure(ex.Message);
            }
        }
    }
}