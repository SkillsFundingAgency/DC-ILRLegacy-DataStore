using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    public partial class LearningDeliveryWorkPlacement
    {
        public int Id { get; set; }
        public int Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public int AimSeqNumber { get; set; }
        public DateTime WorkPlaceStartDate { get; set; }
        public DateTime? WorkPlaceEndDate { get; set; }
        public int WorkPlaceMode { get; set; }
        public int? WorkPlaceEmpId { get; set; }
    }
}
