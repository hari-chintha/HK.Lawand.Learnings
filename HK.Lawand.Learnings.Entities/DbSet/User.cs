namespace HK.Lawand.Learnings.Entities.DbSet
{
    public class User : BaseEntitiy
    {
        public User()
        {
            PublicMetrics = new HashSet<PublicMetrics>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateTime DataOfBirth { get; set; }

        public virtual ICollection<PublicMetrics> PublicMetrics { get; set; }
    }
}
