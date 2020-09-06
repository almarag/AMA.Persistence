using System;
using System.Collections.Generic;
using System.Text;

namespace AMA.Persistence.Models
{
    public class PersonModel : Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
