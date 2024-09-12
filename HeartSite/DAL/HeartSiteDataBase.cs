using Microsoft.EntityFrameworkCore;

namespace HeartSite.DAL
{
    public class HeartSiteDataBase : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

        public HeartSiteDataBase(DbContextOptions<HeartSiteDataBase> options) : base(options)
     {

     }



    }
}
