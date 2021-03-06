﻿using Audemus.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Audemus.Data
{
    public class InMemoryContactData : IContactData
    {
        readonly List<Contact> contacts;


        public InMemoryContactData()
        {
            contacts = new List<Contact>()
            {
                new Contact { Id = 1, Name = "Alfred Law Office", StreetNumber = "1123", StreetName = "Mountain View Dr.", CityLocation = "Houston", StateLocation = "Texas",
                Phone = "8322221535", Email = "Alfredlaw@gmail.com", DateAttempted = "05/28/2019", EmployeeContact = ContactType.NoResponseLeftVoiceMail},

                new Contact { Id = 2, Name = "Jersey Jurisdiction Firm", StreetNumber = "8796", StreetName = "Scott St.", CityLocation = "Houston", StateLocation = "Texas",
                Phone = "8324441433", Email = "JerseyJ@ymail.com", DateAttempted = "05/22/2019", EmployeeContact = ContactType.ContactMadeFollowUp},

                new Contact { Id = 3, Name = "Smith & Sanders Associates", StreetNumber = "3582", StreetName = "Lobelia Dr.", CityLocation = "Cypress", StateLocation = "Texas",
                Phone = "2813581298", Email = "SSassociates@gmail.com", DateAttempted = "06/10/2019", EmployeeContact = ContactType.NoResponseLeftVoiceMail},

                new Contact { Id = 4, Name = "Turner Law Office", StreetNumber = "3354", StreetName = "Carolina", CityLocation = "Pasadena", StateLocation = "Texas",
                Phone = "8322221535", Email = "TurnerLaw@gmail.com", DateAttempted = "06/01/2019", EmployeeContact = ContactType.ContactMadeDoNotFollowUp}

            };
        }

        public Contact GetById(int id)
        {
            return contacts.SingleOrDefault(c => c.Id == id);
        }

        public Contact Add(Contact newContact)
        {
            contacts.Add(newContact);
            newContact.Id = contacts.Max(c => c.Id) + 1;
            return newContact;
        }

        public Contact Update(Contact updatedContact)
        {
            var contact = contacts.SingleOrDefault(c => c.Id == updatedContact.Id);
            if(contact != null)
            {
                contact.Name = updatedContact.Name;
                contact.StreetNumber = updatedContact.StreetNumber;
                contact.StreetName = updatedContact.StreetName;
                contact.CityLocation = updatedContact.CityLocation;
                contact.StateLocation = updatedContact.StateLocation;
                contact.Phone = updatedContact.Phone;
                contact.Email = updatedContact.Email;
                contact.DateAttempted = updatedContact.DateAttempted;
                contact.EmployeeContact = updatedContact.EmployeeContact;

            }
            return contact;
        }


        public int Commit()
        {
            return 0;
        }


        public IEnumerable<Contact> GetContactsByName(string name = null)
        {

            return from c in contacts
                   where string.IsNullOrEmpty(name) ||c.Name.StartsWith(name)
            orderby c.Name
            select c;
        }

        public Contact Delete(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if(contact != null)
            {
                contacts.Remove(contact);
            }
            return contact;
        }

        public int GetCountOfContacts()
        {
            return contacts.Count();
        }
    }
}
