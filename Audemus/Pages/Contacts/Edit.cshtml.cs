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

        [BindProperty]
        public Contact Contact { get; set; }
        public IEnumerable<SelectListItem> ContactTypes { get; set; }
        public EditModel(IContactData contactData,
                        IHtmlHelper htmlHelper)
        {
            this.contactData = contactData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? contactId)
        {
            ContactTypes = htmlHelper.GetEnumSelectList<ContactType>();
            if (contactId.HasValue)
            {
                Contact = contactData.GetById(contactId.Value);
            }
            else
            {
                Contact = new Contact();
            }
            if (Contact == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ContactTypes = htmlHelper.GetEnumSelectList<ContactType>();
                return Page();
            }
            if (Contact.Id > 0)
            {
                contactData.Update(Contact);
            }
            else
            {
                contactData.Add(Contact);
            }
            contactData.Commit();
            TempData["Message"] = "Contact Saved!";
            return RedirectToPage("./Detail", new { contactId = Contact.Id });
        }

    }
}