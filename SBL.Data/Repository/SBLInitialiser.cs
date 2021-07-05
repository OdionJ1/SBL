using SBL.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Repository
{
    public class SBLInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<SBLContext>
    {
        protected override void Seed(SBLContext context)
        {
            Book book1 = new Book() { Name = "Bookname1", DateAdded = Convert.ToDateTime("12/12/20"), BookFile = "book.pdf", NoOfPages = 100 };
            Author author1 = new Author() { Name = "Author1" };
            Category category1 = new Category() {Name ="Horror" };
            User user1 = new User() { Name = "Amy", Email = "amy@gmail.com", PhoneNumber = 7654321345};

            context.Books.Add(book1);
            context.Authors.Add(author1);
            context.Categories.Add(category1);
            context.Users.Add(user1);

            context.SaveChanges();

        }
    }
}
