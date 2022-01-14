using Azen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.ViewModels
{
    public class VmOrder
    {
        public List<SizeColorToProduct> SizeColorToProducts { get; set; }
        public CustomUser CustomUser { get; set; }
    }
}
