using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeartSite.DAL
{
    public class HeartSiteDataBase : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }


        public HeartSiteDataBase(DbContextOptions<HeartSiteDataBase> options) : base(options)
        {
     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Category)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.CategoryIndicator);
            base.OnModelCreating(modelBuilder);
        }
    }
}
