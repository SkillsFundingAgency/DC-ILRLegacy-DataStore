using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1718EF.Console.Entities
{
    public partial class EsfvalCases
    {
        public int LearnerId { get; set; }
        public int? Ukprn { get; set; }
        public string CaseData { get; set; }
    }
}
