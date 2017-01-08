using System.Data.Entity;
using DataAccessLayer.Models;
using Microsoft.AspNet.Identity.EntityFramework;
namespace DataAccessLayer
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("DemoConnection")
        {
            Database.SetInitializer<ApplicationContext>(new DropCreateDatabaseAlways<ApplicationContext>());
        }

        public ApplicationContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Database.SetInitializer<ApplicationContext>(new DropCreateDatabaseAlways<ApplicationContext>());
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<File> Files { get; set; }

        public DbSet<AppTask> Tasks { get; set; }

    }
}
