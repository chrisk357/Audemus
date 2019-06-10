using Audemus.Core;
using System.Collections.Generic;
using System.Text;

namespace Audemus.Data
{
    public interface IContactData
    {
        IEnumerable<Contact> GetContactsByName(string name);
        Contact GetById(int id);
        Contact Update(Contact updatedContact);
        Contact Add(Contact newContact);
        Contact Delete(int id);
        int Commit();
    }
}
