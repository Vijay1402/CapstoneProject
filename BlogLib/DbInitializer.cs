using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace BlogLib
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<BlogDbContext>
    {
        protected override void Seed(BlogDbContext context)
        {
            // Add default data to AdminInfo table
            context.Admins.Add(new AdminInfo { EmailId = "admin@example.com", Password = "admin123" });
            context.SaveChanges();
        }
    }
}
