using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.RoleAuthorization.Models
{
    public class Interfaces : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
