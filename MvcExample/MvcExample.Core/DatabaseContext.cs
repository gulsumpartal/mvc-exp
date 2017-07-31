using System.Data.Entity;
using System.Configuration;
using MvcExample.Domain.User;

namespace MvcExample.Core
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext() :base(ConfigurationManager.ConnectionStrings["DefaultConnection"].Name)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
