using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        //prop Erişim belirleyici
        //değişken türü ve ismi
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesciption { get; set; }
        public bool CategoryStatus { get; set; }


        public List<Blog> Blogs { get; set; } ////1-
    }
}
