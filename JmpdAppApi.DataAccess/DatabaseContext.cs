using JmpdAppApi.DataAccess.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace JmpdAppApi.DataAccess
{
    public class DatabaseContext : DbContext ,IDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
    }
}