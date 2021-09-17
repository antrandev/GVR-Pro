using Data.Entity.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApplication.Controllers
{
    public class GetDataController : BaseController
    {
        [HttpPost]
        public IActionResult SaveChangeOtherResource(OtherReousrce model)
        {

            return Json("");
        }
    }
}
