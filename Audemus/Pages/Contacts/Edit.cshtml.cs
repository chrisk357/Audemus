using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Audemus.Core;
using Audemus.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Audemus.Pages.Contacts
{
    public class EditModel : PageModel
    {
        private readonly IContactData contactData;
        private readonly IHtmlHelper htmlHelper;

        public Contact Contact { get; set; }
        public IEnumerable <SelectListItem> EmployeeContacts { get; set; }
        public EditModel(IContactData contactData)
        {
            this.contactData = contactData;
        }
        public IActionResult OnGet(int contactId)
        {
            EmployeeContacts = htmlHelper.GetEnumSelectList<EmployeeContactType>();
            Contact = contactData.GetById(contactId);
            if(Contact == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}