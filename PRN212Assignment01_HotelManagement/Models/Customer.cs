﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN212Assignment01_HotelManagement.Models
{
    public class Customer
    {
        public string CustomerFullName { get; set; }
        public string Telephone { get; set; }
        public string EmailAddress { get; set; }
        public DateOnly? CustomerBirthday { get; set; }
        public int? CustomerStatus { get; set; }
        public string Password { get; set; }
    }
}
