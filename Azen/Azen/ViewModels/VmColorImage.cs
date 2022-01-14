using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.ViewModels
{
    public class VmColorImage
    {
        public int ColorId { get; set; }
        public IFormFile[] Image { get; set; }
        public List<string> ImageBase64 = new List<string>();
    }
}
