using JmpdAppApi.DataAccess.Models;
using JmpdAppApi.DataAccess.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace JmpdAppApi.DataAccess
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public virtual DbSet<TrafficOfficial> TrafficOfficials { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
    }
}