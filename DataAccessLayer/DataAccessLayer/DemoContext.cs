using System.Data.Entity;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("DemoConnection")
        {
            Database.SetInitializer<DemoContext>(new DropCreateDatabaseIfModelChanges<DemoContext>());
        }

        public DemoContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Database.SetInitializer<DemoContext>(new DropCreateDatabaseIfModelChanges<DemoContext>());
        }

        public static DemoContext Create()
        {
            return new DemoContext();
        }

        public DbSet<ApplicationUser> Users {get;set;}
        public DbSet<Post> Posts { get; set; }
        public DbSet<File> Files { get; set; }

        public DbSet<Task> Tasks { get; set; }

    }
}
