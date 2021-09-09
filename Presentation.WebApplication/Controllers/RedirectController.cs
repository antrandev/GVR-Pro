using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApplication.Controllers
{
    public class RedirectController : Controller
    {
        public RedirectResult MyProfile()
        {
            return Redirect("https://www.c-sharpcorner.com/members/farhan-ahmed24");
        }
        public RedirectResult Profile()
        {
            return RedirectPermanent("https://www.c-sharpcorner.com/members/farhan-ahmed24");
        }

        public RedirectToActionResult EmployeeList()
        {
            return RedirectToAction("Index", "Employees");
        }

        public RedirectToRouteResult DepartmentList()
        {
            return RedirectToRoute(new { action = "Index", controller = "Departments", area = "" });
        }

        public LocalRedirectResult LocalRedirect()
        {
            return LocalRedirect("/Home/Index");
        }


        //        <h3 class="text-uppercase">RedirectResult Action in core mvc</h3>
        //<ul class="list-group list-group-horizontal">
        //    <li class="list-group-item"><a asp-action="MyProfile" asp-controller="Home" target="_blank">Redirect Result</a></li>
        //    <li class="list-group-item"><a asp-action="EmployeeList" asp-controller="Home" target="_blank">RedirectToActionResult</a></li>
        //    <li class="list-group-item"><a asp-action="DepartmentList" asp-controller="Home" target="_blank">RedirectToRouteResult</a></li>
        //    <li class="list-group-item"><a asp-action="LocalRedirect" asp-controller="Home" target="_blank">LocalRedirectResultt</a></li>
        //</ul>
    }
}
