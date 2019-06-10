using System;
using System.Collections.Generic;
using System.Text;

namespace Audemus.Core
{

    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string CityLocation { get; set; }
        public string StateLocation { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DateAttempted { get; set; }
        public ContactType EmployeeContact { get; set; }

    }
}
