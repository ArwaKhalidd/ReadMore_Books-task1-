using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMore_Books_task1_.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }
        public int PublishedYear { get; set; }
        public bool InStock { get; set; }

      
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
