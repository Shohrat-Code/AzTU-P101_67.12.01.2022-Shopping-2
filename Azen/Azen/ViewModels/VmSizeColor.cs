using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.ViewModels
{
    public class VmSizeColor
    {
        public int ColorId { get; set; }
        public List<int> SizeIds { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
