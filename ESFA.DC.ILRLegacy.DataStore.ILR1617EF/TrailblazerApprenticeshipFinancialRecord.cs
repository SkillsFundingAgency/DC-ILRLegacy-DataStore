using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    public partial class TrailblazerApprenticeshipFinancialRecord
    {
        public int Id { get; set; }
        public int Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public int AimSeqNumber { get; set; }
        public string TbfinType { get; set; }
        public int? TbfinCode { get; set; }
        public DateTime? TbfinDate { get; set; }
        public int TbfinAmount { get; set; }
    }
}
