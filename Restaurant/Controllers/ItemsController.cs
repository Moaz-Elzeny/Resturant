using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public ItemsController(ApplicationDbContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            List<Item> items = _Context.items.ToList(); 
            return View(items);
        }
        public IActionResult Create()
        {
            ViewBag.Order = this._Context.orders.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Item model)
        {
            if (ModelState.IsValid)
            {
                _Context.items.Add(model);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Orders = this._Context.orders.ToList();
            return View();
        }
        public IActionResult Edit(int ID)
        {
            Item data = this._Context.items.Where(e => e.ItemID == ID).FirstOrDefault();
            ViewBag.Orders = this._Context.orders.ToList();
            return View("Create", data);
        }

        [HttpPost]
        public IActionResult Edit(Item model)
        {
            if (ModelState.IsValid)
            {
                _Context.items.Update(model);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Orders = this._Context.orders.ToList();
            return View("Index", model);
        }

        public IActionResult Delete(int ID)
        {
            Item data = this._Context.items.Where(e => e.ItemID == ID).FirstOrDefault();
            if (data != null)
            {
                _Context.items.Remove(data);
                _Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
