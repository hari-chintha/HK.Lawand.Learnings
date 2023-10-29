using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.Lawand.Learnings.Entities.DbSet
{
    public class PublicMetrics
    {
        public Guid Id { get; set; }
        public int FollowersCount { get; set; }
        public int FollowingCount { get; set; }
        public int TweetCount { get; set; }
        public int ListedCount { get; set; }

        public Guid UserId{ get; set; }
        public virtual User User { get; set; }
    }
}
