﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidMassTesting.Model.Mustache
{
    /// <summary>
    /// Variables for PDF generation
    /// </summary>
    public class TestRegistration
    {

        /// <summary>
        /// RegistrationCode
        /// </summary>
        public string RegistrationCode { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Personal number or insurance number
        /// </summary>
        public string PersonalNumber { get; set; }
        /// <summary>
        /// Passport number for foreigners
        /// </summary>
        public string PassportNumber { get; set; }
        /// <summary>
        /// DateTime
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Link to testing place
        /// </summary>
        public string FrontedURL { get; set; }
        /// <summary>
        /// Bar code
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// QRCode
        /// </summary>
        public string QRCode { get; set; }
        /// <summary>
        /// Identification of testing provider
        /// </summary>
        public string TestingEntity { get; set; }
        /// <summary>
        /// Address where user has been tested
        /// </summary>
        public string TestingAddress { get; set; }
        /// <summary>
        /// Product - PCR or Antigen test
        /// </summary>
        public string Product { get; set; }
    }
}
