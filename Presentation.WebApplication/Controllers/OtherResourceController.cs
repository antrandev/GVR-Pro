using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApplication.Controllers
{
    public class OtherResourceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
