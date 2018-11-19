﻿using System;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1718EF
{
    public partial class LearningDelivery
    {
        public int Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public string LearnAimRef { get; set; }
        public int AimType { get; set; }
        public int AimSeqNumber { get; set; }
        public DateTime LearnStartDate { get; set; }
        public DateTime? OrigLearnStartDate { get; set; }
        public DateTime LearnPlanEndDate { get; set; }
        public int FundModel { get; set; }
        public int? ProgType { get; set; }
        public int? FworkCode { get; set; }
        public int? PwayCode { get; set; }
        public int? StdCode { get; set; }
        public int? PartnerUkprn { get; set; }
        public string DelLocPostCode { get; set; }
        public int? AddHours { get; set; }
        public int? PriorLearnFundAdj { get; set; }
        public int? OtherFundAdj { get; set; }
        public string ConRefNumber { get; set; }
        public string EpaorgId { get; set; }
        public int? EmpOutcome { get; set; }
        public int CompStatus { get; set; }
        public DateTime? LearnActEndDate { get; set; }
        public int? WithdrawReason { get; set; }
        public int? Outcome { get; set; }
        public DateTime? AchDate { get; set; }
        public string OutGrade { get; set; }
        public string SwsupAimId { get; set; }
    }
}
