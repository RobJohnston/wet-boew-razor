using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GCIntranet.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            // Test the 404 error page by loading any page that doesn't exist.

            // Test the server message page by uncomment the following line and ensure
            // the Configure method in Startup.cs doesn't use the developer exception page.
            //throw new ApplicationException("Test error page.");
        }
    }
}
