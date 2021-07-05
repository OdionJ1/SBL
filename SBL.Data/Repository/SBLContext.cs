using SBL.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Repository
{
   public class SBLContext : DbContext
    {

        public SBLContext() : base("SBLContext")
        {
            Database.SetInitializer(new SBLInitialiser());
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
