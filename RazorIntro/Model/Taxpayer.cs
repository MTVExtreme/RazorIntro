using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorIntro.Model
{
    public class Taxpayer
    {
        public int TaxPayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }


    }
}
