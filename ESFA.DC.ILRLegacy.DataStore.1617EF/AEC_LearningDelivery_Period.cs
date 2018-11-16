//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESFA.DC.ILRLegacy.DataStore._1617EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class AEC_LearningDelivery_Period
    {
        public int UKPRN { get; set; }
        public string LearnRefNumber { get; set; }
        public int AimSeqNumber { get; set; }
        public int Period { get; set; }
        public Nullable<decimal> DisadvFirstPayment { get; set; }
        public Nullable<decimal> DisadvSecondPayment { get; set; }
        public string FundLineType { get; set; }
        public Nullable<int> InstPerPeriod { get; set; }
        public Nullable<decimal> LDApplic1618FrameworkUpliftBalancingPayment { get; set; }
        public Nullable<decimal> LDApplic1618FrameworkUpliftCompletionPayment { get; set; }
        public Nullable<decimal> LDApplic1618FrameworkUpliftOnProgPayment { get; set; }
        public string LearnDelContType { get; set; }
        public Nullable<decimal> LearnDelFirstEmp1618Pay { get; set; }
        public Nullable<decimal> LearnDelFirstProv1618Pay { get; set; }
        public Nullable<int> LearnDelLevyNonPayInd { get; set; }
        public Nullable<decimal> LearnDelSecondEmp1618Pay { get; set; }
        public Nullable<decimal> LearnDelSecondProv1618Pay { get; set; }
        public Nullable<decimal> LearnDelSFAContribPct { get; set; }
        public Nullable<bool> LearnSuppFund { get; set; }
        public Nullable<decimal> LearnSuppFundCash { get; set; }
        public Nullable<decimal> MathEngBalPayment { get; set; }
        public Nullable<decimal> MathEngBalPct { get; set; }
        public Nullable<decimal> MathEngOnProgPayment { get; set; }
        public Nullable<decimal> MathEngOnProgPct { get; set; }
        public Nullable<decimal> ProgrammeAimBalPayment { get; set; }
        public Nullable<decimal> ProgrammeAimCompletionPayment { get; set; }
        public Nullable<decimal> ProgrammeAimOnProgPayment { get; set; }
    }
}
