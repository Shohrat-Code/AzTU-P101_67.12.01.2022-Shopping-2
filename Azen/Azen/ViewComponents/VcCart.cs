using Azen.Data;
using Azen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.ViewComponents
{
    public class VcCart : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VcCart(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IViewComponentResult Invoke()
        {
            string cart = _httpContextAccessor.HttpContext.Request.Cookies["cart"];
            List<SizeColorToProduct> sizeColorToProducts = new List<SizeColorToProduct>();
            if (!string.IsNullOrEmpty(cart))
            {
                List<string> cartList = cart.Split("-").ToList();

                sizeColorToProducts = _context.SizeColorToProducts.Include(cp => cp.ColorToProduct).ThenInclude(pi => pi.ProductImages)
                                                                  .Include(cp => cp.ColorToProduct).ThenInclude(pi => pi.Product)
                                                                  .Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();
            }

            return View(sizeColorToProducts);
        }
    }
}
