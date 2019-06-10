using Audemus.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audemus.Data
{
    public class AudemusDbContext : DbContext
    {
        public AudemusDbContext(DbContextOptions<AudemusDbContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
