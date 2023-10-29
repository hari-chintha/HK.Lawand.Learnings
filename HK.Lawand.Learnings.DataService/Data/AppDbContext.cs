using HK.Lawand.Learnings.Entities.DbSet;
using Microsoft.EntityFrameworkCore;

namespace HK.Lawand.Learnings.DataService.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {  }

        //define the db entities
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PublicMetrics> PublicMetrics { get; set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //define ther relation between the tables.
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PublicMetrics>(entity =>
            {
                entity.HasOne(d => d.User)
                .WithMany(p => p.PublicMetrics)
                .HasForeignKey(p => p.User.Id)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_PublicMetrics_Driver");
            });  

        }

    }
}
