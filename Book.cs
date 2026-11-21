using System;
using System.Collections.Generic;
using System.Text;

namespace EFCORE1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishedYear { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
