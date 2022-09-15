using JmpdAppApi.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmpdAppApi.Core.Services.IServices
{
    public interface IAuthenticationService
    {
        Result SignInUser(UserDto user);
    }
}
