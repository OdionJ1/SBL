using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBL.Data.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public System.DateTime DateAdded { get; set; }

        public string BookFile { get; set; }

        public int NoOfPages { get; set; }

        //   public virtual ICollection<Book> Books { get; set; }
    }
}
