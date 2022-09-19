using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmpdAppApi.Common.Dto
{
    public class LoggedInOfficialDto
    {
        public string OfficerNumber { get; set; }

        public string Name { get; set; }

        public int RoleId { get; set; }

        public int ProvinceId { get; set; }

    }
}
