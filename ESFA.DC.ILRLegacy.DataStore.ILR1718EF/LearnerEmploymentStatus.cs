using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1718EF
{
    public partial class LearnerEmploymentStatus
    {
        public int Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public int? EmpStat { get; set; }
        public DateTime DateEmpStatApp { get; set; }
        public int? EmpId { get; set; }
    }
}
