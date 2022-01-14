using Azen.Data;
using Azen.Models;
using Azen.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1, double itemCount = 3)
        {
            VmProduct model = new VmProduct();

            List<Product> products = _context.Products
                                        .Include(cp => cp.ColorToProducts).ThenInclude(pi => pi.ProductImages)
                                        .Include(cp => cp.ColorToProducts).ThenInclude(sc => sc.SizeColorToProducts).ToList();

            model.PageCount = (int)Math.Ceiling(products.Count / itemCount);
            model.Products = products.Skip((page - 1) * (int)itemCount).Take((int)itemCount).ToList();
            model.Page = page;
            model.ItemCount = itemCount;

            return View(model);
        }

        public IActionResult AddToCart(int sizeColorProductId)
        {
            string oldCart = Request.Cookies["cart"];
            string newCart = "";

            if (string.IsNullOrEmpty(oldCart))
            {
                newCart = sizeColorProductId + "";
            }
            else
            {
                List<string> oldCartList = oldCart.Split("-").ToList();
                if (oldCartList.Any(i => i == sizeColorProductId.ToString()))
                {
                    oldCartList.Remove(sizeColorProductId.ToString());
                }
                else
                {
                    oldCartList.Add(sizeColorProductId.ToString());
                }

                newCart = string.Join("-", oldCartList);
            }

            Response.Cookies.Append("cart", newCart);
            return RedirectToAction("Index");
        }

        public IActionResult Cart()
        {
            string cart = Request.Cookies["cart"];
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

        public IActionResult Checkout()
        {
            VmOrder model = new VmOrder();
            string cart = Request.Cookies["cart"];
            if (!string.IsNullOrEmpty(cart))
            {
                List<string> cartList = cart.Split("-").ToList();

                model.SizeColorToProducts = _context.SizeColorToProducts.Include(cp => cp.ColorToProduct).ThenInclude(pi => pi.Product)
                                                                  .Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Checkout(VmOrder model)
        {
            if (ModelState.IsValid)
            {
                //Request to Bank api
                //
                //
                //
                //
                bool canWithdraw = true;




                if (canWithdraw)
                {
                    //Create customer
                    CustomUser costomer = new CustomUser();

                    if (!_context.CustomUsers.Any(c => c.Email == model.CustomUser.Email))
                    {
                        CustomUser newCostomer = new CustomUser()
                        {
                            Name = model.CustomUser.Name,
                            Surname = model.CustomUser.Surname,
                            Email = model.CustomUser.Email,
                            PhoneNumber = model.CustomUser.PhoneNumber,
                            Address = model.CustomUser.Address,
                            UserName = model.CustomUser.Email
                        };
                        _context.CustomUsers.Add(newCostomer);
                        _context.SaveChanges();

                        costomer = newCostomer;
                    }
                    else
                    {
                        costomer = _context.CustomUsers.FirstOrDefault(c=>c.Email==model.CustomUser.Email);
                    }

                    //Update stock
                    string cart = Request.Cookies["cart"];
                    List<SizeColorToProduct> sizeColorToProducts = new List<SizeColorToProduct>();
                    if (!string.IsNullOrEmpty(cart))
                    {
                        List<string> cartList = cart.Split("-").ToList();

                        sizeColorToProducts = _context.SizeColorToProducts.Include(cp => cp.ColorToProduct).ThenInclude(pi => pi.Product)
                                                                          .Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();
                    }

                    foreach (var item in sizeColorToProducts)
                    {
                        _context.SizeColorToProducts.Find(item.Id).Quantity--;
                    }
                    _context.SaveChanges();


                    //Invoice
                    Sale sale = new Sale();
                    int invoiceNo = 1;
                    if (_context.Sales.Any())
                    {
                        invoiceNo = Convert.ToInt32(_context.Sales.LastOrDefault().No) + 1;
                    }

                    sale.No = invoiceNo.ToString().PadLeft(11);
                    if (sizeColorToProducts.Sum(s=>s.Price)<100)
                    {
                        sale.Shipping = 10;
                    }
                    sale.CustomerId = costomer.Id;
                    sale.CreatedDate = DateTime.Now;
                    _context.Sales.Add(sale);
                    _context.SaveChanges();


                    foreach (var item in sizeColorToProducts)
                    {
                        SaleItem saleItem = new SaleItem();
                        saleItem.Price = item.Price;
                        saleItem.Quantity = item.Quantity;
                        saleItem.ProductId= item.Id;
                        saleItem.SaleId= sale.Id;

                        _context.SaleItems.Add(saleItem);
                    }

                    _context.SaveChanges();
                }
            }























            return View();
        }
    }
}
