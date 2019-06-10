using System.Collections.Generic;
using Audemus.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Audemus.Data
{
    public class SqlContactData : IContactData
    {
        private readonly AudemusDbContext db;

        public SqlContactData(AudemusDbContext db)
        {
            this.db = db;
        }

        public Contact Add(Contact newContact)
        {
            db.Add(newContact);
            return newContact;
        }

        public int Commit()
        {
            return db.SaveChanges();
            
        }

        public Contact Delete(int id)
        {
            var contact = GetById(id);
            if(contact != null)
            {
                db.Contacts.Remove(contact);
            }
            return contact;
        }

        public Contact GetById(int id)
        {
            return db.Contacts.Find(id);
        }

        public IEnumerable<Contact> GetContactsByName(string name)
        {
            var query = from c in db.Contacts
                        where c.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby c.Name
                        select c;
            return query;
        }

        public int GetCountOfContacts()
        {
            return db.Contacts.Count();
        }

        public Contact Update(Contact updatedContact)
        {
            var entity = db.Contacts.Attach(updatedContact);
            entity.State = EntityState.Modified;
            return updatedContact;
        }
    }
}
