using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    public partial class LlddandHealthProblem
    {
        public int Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public int Llddcat { get; set; }
        public int? PrimaryLldd { get; set; }
    }
}
