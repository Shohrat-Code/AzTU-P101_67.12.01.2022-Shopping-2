using Azen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.ViewModels
{
    public class VmProduct
    {
        public List<Product> Products { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public int PageCount { get; set; }
        public double ItemCount { get; set; }
        public int Page { get; set; }
    }
}
