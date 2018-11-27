using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    public partial class ValfdValidationError
    {
        public int Ukprn { get; set; }
        public long AimSeqNumber { get; set; }
        public string ErrorString { get; set; }
        public string FieldValues { get; set; }
        public string LearnRefNumber { get; set; }
        public string RuleId { get; set; }
    }
}
