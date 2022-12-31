using JmpdAppApi.Common;
using JmpdAppApi.Common.Dto;

namespace JmpdAppApi.Core.Services.IServices
{
    public interface IAuthenticationService
    {
         Result<LoggedInOfficialDto> SignIn(OfficialSignInDto user);
    }
}
