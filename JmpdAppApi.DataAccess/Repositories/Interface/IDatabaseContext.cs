using JmpdAppApi.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using JmpdAppApi.DataAccess.Models;

namespace JmpdAppApi.DataAccess.Repositories.Interface
{
    public interface IDatabaseContext
    {
        DbSet<TrafficOfficial> TrafficOfficials { get; set; }
         DbSet<Gender> Genders { get; set; }

        DbSet<Role> Roles { get; set; }

        DbSet<Title> Titles { get; set; }
    }
}
