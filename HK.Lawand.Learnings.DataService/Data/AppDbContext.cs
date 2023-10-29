using HK.Lawand.Learnings.Entities.DbSet;
using Microsoft.EntityFrameworkCore;

namespace HK.Lawand.Learnings.DataService.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {  }

        //define the db entities
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PublicMetrics> PublicMetrics { get; set; }

    }
}
