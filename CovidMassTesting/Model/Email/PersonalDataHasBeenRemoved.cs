﻿namespace CovidMassTesting.Model.Email
{
    /// <summary>
    /// Email sent when test was not positive not negative, and needs to be repeated
    /// </summary>
    public class PersonalDataRemovedEmail : IEmail
    {
        /// <summary>
        /// Template identifier
        /// </summary>
        public override string TemplateId => "PersonalDataRemoved";
        /// <summary>
        /// Visitor name
        /// </summary>
        public string Name { get; set; }
    }
}
