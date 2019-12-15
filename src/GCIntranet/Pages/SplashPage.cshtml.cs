using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GCIntranet.Pages
{
    public class SplashPageModel : PageModel
    {
        public IActionResult OnGet(string culture, string returnUrl)
        {
            if (culture == null)
                return null;

            if (returnUrl == null)
                returnUrl = "~/";

            return SetLanguage(culture, returnUrl);
        }

        /// <summary>
        /// Set a culture cookie.
        /// </summary>
        /// <param name="culture">One of the supportedCultures defined in Startup.cs ConfigureServices() method.</param>
        /// <param name="returnUrl">The page where the user should be sent to after setting the cookie.</param>
        private IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}