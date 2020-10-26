﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidMassTesting.Model
{
    public class Visitor
    {
        public int Id { get; set; }
        public string PersonType { get; set; }
        public string Passport { get; set; }
        public string RC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public long ChosenSlot { get; set; }
        public string ChosenPlaceId { get; set; }
        public string Result { get; set; } = "test-not-taken";
    }
}