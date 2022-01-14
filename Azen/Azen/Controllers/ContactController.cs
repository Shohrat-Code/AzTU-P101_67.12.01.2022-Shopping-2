using Azen.Data;
using Azen.Models;
using Azen.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Message(VmContact model)
        {
            if (ModelState.IsValid)
            {
                model.Message.CreatedDate = DateTime.Now;
                _context.Messages.Add(model.Message);
                _context.SaveChanges();
                HttpContext.Session.SetString("Success", "Your message has been sent successfully!");
                return RedirectToAction("index");
            }

            HttpContext.Session.SetString("Error", "Model is not valid");
            return RedirectToAction("index");
        }
    }
}
