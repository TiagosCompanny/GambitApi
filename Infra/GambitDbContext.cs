using Microsoft.EntityFrameworkCore;

namespace GambitApi.Infra
{
    public class GambitDbContext : DbContext
    {
        public GambitDbContext(DbContextOptions<GambitDbContext> options) : base(options)
        {
               
        }
    }
}
