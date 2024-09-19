using HeartSite.TestClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace HeartSite.DAL
{
    public class TestDataBase : DbContext
    {
        public DbSet<CommentTest> CommentTests { get; set; }
        public DbSet<PersonTest> PersonTests { get; set; }
        //fix Error with this Constructor
        public TestDataBase() { }
        public TestDataBase(DbContextOptions<TestDataBase> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=TestDataBase;Integrated Security=True;TrustServerCertificate=True");


        }
    }
}
    
