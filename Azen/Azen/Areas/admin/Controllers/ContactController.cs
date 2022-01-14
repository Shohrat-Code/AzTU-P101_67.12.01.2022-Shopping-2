using Azen.Data;
using Azen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azen.Areas.admin.Controllers
{
    [Area("admin")]
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
        public IActionResult Message()
        {
            return View(_context.Messages.ToList());
        }

        public IActionResult Delete(int? id)
        {

            if (id==null)
            {
                return NotFound();
            }

            Message message = _context.Messages.Find(id);


            if (message == null)
            {
                return NotFound();
            }
            _context.Messages.Remove(message);
            _context.SaveChanges();

            return RedirectToAction("Message");
        }
    }
}
