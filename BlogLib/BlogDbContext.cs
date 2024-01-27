using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BlogLib
{
    public class BlogDbContext : DbContext
    {
        public DbSet<AdminInfo> Admins { get; set; }
        public DbSet<EmpInfo> Employees { get; set; }
        public DbSet<BlogInfo> Blogs { get; set; }

        public BlogDbContext() : base("BlogStr")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BlogDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure relationships, keys, etc.
            base.OnModelCreating(modelBuilder);
        }
    }
}
