using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Audemus.Core;
using Audemus.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Audemus.Pages.Contacts
{
    public class DetailModel : PageModel
    {
        private readonly IContactData contactData;
        [TempData]
        public string Message { get; set; }
        public Contact Contact { get; set; }

        public DetailModel(IContactData contactData)
        {
            this.contactData = contactData;
        }

        

        public IActionResult OnGet(int contactId)
        {
            Contact = contactData.GetById(contactId);
            if(Contact == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();

        }
    }
}