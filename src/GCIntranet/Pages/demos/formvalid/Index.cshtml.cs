using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GCIntranet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GCIntranet.Pages.demos.formvalid
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ContactInformation ContactInformation { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO: Do something with the submitted data.

            return RedirectToPage("./Index");
        }
    }
}
