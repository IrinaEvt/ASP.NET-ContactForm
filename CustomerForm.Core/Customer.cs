using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerForm.Core
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string FirstName { get; set; }

        [Required, StringLength(80)]
        public string LastName { get; set; }

        [Required, StringLength(80)]
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        [Phone]
        public string Phone { get; set; }
        public double Price { get; set; }
        public DateTime Birthday { get; set; }

    }

}
