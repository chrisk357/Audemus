using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Audemus.Data;
using Audemus.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Audemus.Pages.Contacts
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IContactData contactData;

        public string Message { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }
        public ListModel(IConfiguration config, IContactData contactData)
        {
            this.config = config;
            this.contactData = contactData;
        }

        public void OnGet()
        {
            
            Contacts = contactData.GetContactsByName(SearchTerm);

        }
    }
}