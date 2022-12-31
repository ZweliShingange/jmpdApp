namespace JmpdAppApi.Common.Mappers
{
    using JmpdAppApi.Common.Dto;
    using JmpdAppApi.DataAccess.Models;

    public static class Mapper
    {
        public static LoggedInOfficialDto MapToLoggedInOfficial(TrafficOfficial trafficOfficial)
        {
            return new LoggedInOfficialDto
            {
                Name = trafficOfficial.Name,
                OfficerNumber = trafficOfficial.OfficerNumber,
                ProvinceName = trafficOfficial.ProvinceId.ToString(),
                RoleName = trafficOfficial.RoleId.ToString(),
            };
        }
    }
}
