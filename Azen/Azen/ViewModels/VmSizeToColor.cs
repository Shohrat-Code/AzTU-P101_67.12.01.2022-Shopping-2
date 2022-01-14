using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.ViewModels
{
    public class VmSizeToColor
    {
        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
