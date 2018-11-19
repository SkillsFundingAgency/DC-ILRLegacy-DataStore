using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1718EF.Console.Entities
{
    public partial class LearnerHefinancialSupport
    {
        public int Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public int Fintype { get; set; }
        public int Finamount { get; set; }
    }
}
