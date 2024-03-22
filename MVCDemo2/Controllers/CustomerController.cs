using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo2.Controllers
{
    public class CustomerController : Controller
    {
        public static List<CustomerEntity> registeredCustomers
            = new List<CustomerEntity>();

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Register(CustomerEntity customerEntity)
        {
            registeredCustomers.Add(customerEntity);
            return View("ListCustomers", registeredCustomers);
        }
        public IActionResult Registration()
        {
            return View();
        }
    }
}

