//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESF_LearningDeliveryDeliverable_Period
    {
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public int AimSeqNumber { get; set; }
        public string DeliverableCode { get; set; }
        public int Period { get; set; }
        public Nullable<decimal> AchievementEarnings { get; set; }
        public Nullable<decimal> AdditionalProgCostEarnings { get; set; }
        public Nullable<long> DeliverableVolume { get; set; }
        public Nullable<decimal> ProgressionEarnings { get; set; }
        public Nullable<decimal> StartEarnings { get; set; }
        public Nullable<int> ReportingVolume { get; set; }
    }
}