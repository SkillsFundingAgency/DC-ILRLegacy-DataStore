using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1718EF
{
    public partial class ContactPreference
    {
        public int Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public string ContPrefType { get; set; }
        public int ContPrefCode { get; set; }
    }
}
