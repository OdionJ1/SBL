using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Models.Domain
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public virtual ICollection<Author> Authors { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
