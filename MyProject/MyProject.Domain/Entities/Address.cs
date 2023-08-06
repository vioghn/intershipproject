﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyProject.Domain.Entities
{
    public class Address
    {
        public int AddressId { get; set;  }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
       
    }
}
