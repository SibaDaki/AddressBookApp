﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp.Models.Models
{
    public class AddressBook
    {
        public int id { get; set; }
        public string phoneNumber { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string emailAddress { get; set; }
    }
}
