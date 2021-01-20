using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidMassTesting.Model.SMS
{
    /// <summary>
    /// Test must be repeated
    /// </summary>
    public class TestToRepeatSMS : ISMS
    {
        /// <summary>
        /// Person name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Generate sms message text
        /// </summary>
        /// <returns></returns>
        public override string GetText()
        {
            return $"Dobrý deň {Name}, vyskytol sa technický problém a Váš test bude potrebné zopakovať. Dostavte sa prosím na opätovný odber vzorky. Ďakujeme.";
        }
    }
}
