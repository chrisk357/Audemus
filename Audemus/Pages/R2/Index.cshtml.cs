using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Audemus.Core;
using Audemus.Data;

namespace Audemus.Pages.R2
{
    public class IndexModel : PageModel
    {
        private readonly Audemus.Data.AudemusDbContext _context;

        public IndexModel(Audemus.Data.AudemusDbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contacts.ToListAsync();
        }
    }
}
