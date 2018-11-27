using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    public partial class AeLearningDeliveryPeriod
    {
        public long Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public int AimSeqNumber { get; set; }
        public int Period { get; set; }
        public decimal? ProgrammeAimOnProgPayment { get; set; }
        public decimal? ProgrammeAimCompletionPayment { get; set; }
        public decimal? ProgrammeAimBalPayment { get; set; }
    }
}
