using Azen.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.ViewComponents
{
    public class VcTest2:ViewComponent
    {
        private readonly AppDbContext _context;

        public VcTest2(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
