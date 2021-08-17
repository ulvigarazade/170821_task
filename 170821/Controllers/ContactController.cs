using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _170821.Views.Home
{
    public class ContactController : Controller
    {
        public IActionResult Index(int id)
        {
            return Content("id: " + id);
        }
    }
}
