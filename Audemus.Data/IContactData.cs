using Audemus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Audemus.Data
{
    public interface IContactData
    {
        IEnumerable<Contact> GetContactsByName(string name);
        Contact GetById(int id);
    }

    public class InMemoryContactData : IContactData
    {
        readonly List<Contact> contacts;


        public InMemoryContactData()
        {
            contacts = new List<Contact>()
            {
                new Contact { Id = 1, Name = "Alfred Law Office", CityLocation = "Houston", StateLocation = "Texas",
                Phone = "8322221535", Email = "Alfredlaw@gmail.com", EmployeeContact = EmployeeContactType.NoResponseLeftVM},
                new Contact { Id = 2, Name = "Jersey Jurisdiction Firm", CityLocation = "Houston", StateLocation = "Texas",
                Phone = "8324441433", Email = "JerseyJ@ymail.com", EmployeeContact = EmployeeContactType.ContactMadeFollowUp},
                new Contact { Id = 3, Name = "Smith & Sanders Associates", CityLocation = "Cypress", StateLocation = "Texas",
                Phone = "2813581298", Email = "SSassociates@gmail.com", EmployeeContact = EmployeeContactType.NoResponseLeftVM},
                new Contact { Id = 4, Name = "Turner Law Office", CityLocation = "Pasadena", StateLocation = "Texas",
                Phone = "8322221535", Email = "TurnerLaw@gmail.com", EmployeeContact = EmployeeContactType.ContactMadeNoFollowUp}

            };
        }

        public Contact GetById(int id)
        {
            return contacts.SingleOrDefault(c => c.Id == id);
        }
        public IEnumerable<Contact> GetContactsByName(string name = null)
        {
            return from c in contacts
                   where string.IsNullOrEmpty(name) ||
                   c.Name.StartsWith(name)
            orderby c.Name
            select c;
        }
    }
}
