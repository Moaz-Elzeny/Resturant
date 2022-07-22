using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public OrdersController(ApplicationDbContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            List<Order> order = _Context.orders.ToList();
            return View(order);
        }
    }
}
