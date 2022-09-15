using JmpdAppApi.Common.Dto;
using JmpdAppApi.Core.Services.IServices;
using JmpdAppApi.DataAccess.Repositories.Interface;

namespace JmpdAppApi.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService(IDatabaseContext context)
        {
            this.context = context
        }
        public Result SignInUser(UserDto user)
        {
            
        }
    }
}
//