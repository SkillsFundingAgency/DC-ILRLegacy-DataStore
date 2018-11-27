using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1718EF
{
    public partial class AecCases
    {
        public int Id { get; set; }
        public string LearnRefNumber { get; set; }
        public int? Ukprn { get; set; }
        public string CaseData { get; set; }
    }
}
