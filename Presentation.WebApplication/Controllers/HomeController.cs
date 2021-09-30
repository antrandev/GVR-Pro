using Business.Services;
using Data.Entity;
using Infrastructure.Settings;
using Infrastructure.Utilities.Enum;
using Infrastructure.Utilities.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentation.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DataContext dataContext;
        public HomeController(ILogger<HomeController> logger,DataContext dataContext)
        {
            this.dataContext = dataContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            AppSettingsProvider.CookieslanguageCode = HttpContext.Session.GetString("Lang_Web");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
