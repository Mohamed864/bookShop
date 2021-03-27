using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        [Display(Name="From")]
        [DataType(DataType.Date)]
        public DateTime From { get; set; }

        [Display(Name = "TO")]
        [DataType(DataType.Date)]
        public DateTime TO { get; set; }
        public string Description { get; set; }
    }
}
