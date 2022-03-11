using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Shop
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public Shop()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
        }
    }
}
