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
    public class DeleteModel : PageModel
    {
        private readonly IContactData contactData;

        public Contact Contact { get; set; }

        public DeleteModel(IContactData contactData)
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
        public IActionResult OnPost(int contactId)
        {
            var contact = contactData.Delete(contactId);
            contactData.Commit();

            if(contact == null)
            {
                return RedirectToPage("./NotFound");
            }
            TempData["Message"] = $"{contact.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}