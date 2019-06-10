using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Audemus.Core
{

    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string CityLocation { get; set; }
        public string StateLocation { get; set; }
        [Required, MaxLength(13)]
        public string Phone { get; set; }
        [Required, MaxLength(60)]
        public string Email { get; set; }
        public string DateAttempted { get; set; }
        public ContactType EmployeeContact { get; set; }

    }
}
