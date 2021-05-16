using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Customer : User
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
