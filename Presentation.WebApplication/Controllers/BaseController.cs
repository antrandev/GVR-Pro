using Infrastructure.Settings;
using Infrastructure.Utilities.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Presentation.WebApplication.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApplication.Controllers
{
    public class BaseController : Controller
    {
        [HttpPost]
        public IActionResult SetLanguage(string langs, string pathname)
        {
            HttpContext.Session.SetString("Lang_Web", langs);
            AppSettingsProvider.CookieslanguageCode = HttpContext.Session.GetString("Lang_Web");
            return Json(true);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        public IHttpContextAccessor _httpContextAccessor;
        /// <summary>  
        /// Get the cookie  
        /// </summary>  
        /// <param name="key">Key </param>  
        /// <returns>string value</returns>  
        public string Get(string key)
        {
            return Request.Cookies[key];
        }
        /// <summary>  
        /// set the cookie  
        /// </summary>  
        /// <param name="key">key (unique indentifier)</param>  
        /// <param name="value">value to store in cookie object</param>  
        /// <param name="expireTime">expiration time</param>  
        public void SetCookies(string key = null, string value  = null, string times = null, bool isLang = false)
        {
            CookieOptions option = new CookieOptions();
            if (isLang == true)
            {
                var cookies = new RequestCulture(key);
                var options = DateTimeOffset.UtcNow.AddYears(1);
                Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(cookies),
                new CookieOptions { Expires = options }
                );
                option.Expires = options;
                Response.Cookies.Append("Lang_Web", key, option);
            }
            else
            {
                if (!string.IsNullOrEmpty(times))
                    option.Expires = DateTimeOffset.UtcNow.AddYears(1);
                else
                    option.Expires = DateTime.Now.AddMilliseconds(10);
                Response.Cookies.Append(key, value, option);
            }
        }
        /// <summary>  
        /// Delete the key  
        /// </summary>  
        /// <param name="key">Key</param>  
        public void RemoveCookies(string key)
        {
            Response.Cookies.Delete(key);
        }
    }
}
