using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class BooksType
    {
        public List<Books> Books { get; set; }
        public SelectList Types { get; set; }
        public string BookType { get; set; }
        public string SearchString { get; set; }

    }
}
