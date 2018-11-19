﻿using System;
using System.Collections.Generic;

namespace ESFA.DC.ILRLegacy.DataStore.ILR1617EF.Console.Entities
{
    public partial class AecApprenticeshipPriceEpisodePeriod
    {
        public int Ukprn { get; set; }
        public string LearnRefNumber { get; set; }
        public string PriceEpisodeIdentifier { get; set; }
        public int Period { get; set; }
        public decimal? PriceEpisodeApplic1618FrameworkUpliftBalancing { get; set; }
        public decimal? PriceEpisodeApplic1618FrameworkUpliftCompletionPayment { get; set; }
        public decimal? PriceEpisodeApplic1618FrameworkUpliftOnProgPayment { get; set; }
        public decimal? PriceEpisodeBalancePayment { get; set; }
        public decimal? PriceEpisodeBalanceValue { get; set; }
        public decimal? PriceEpisodeCompletionPayment { get; set; }
        public decimal? PriceEpisodeFirstDisadvantagePayment { get; set; }
        public decimal? PriceEpisodeFirstEmp1618Pay { get; set; }
        public decimal? PriceEpisodeFirstProv1618Pay { get; set; }
        public int? PriceEpisodeInstalmentsThisPeriod { get; set; }
        public int? PriceEpisodeLevyNonPayInd { get; set; }
        public decimal? PriceEpisodeLsfcash { get; set; }
        public decimal? PriceEpisodeOnProgPayment { get; set; }
        public decimal? PriceEpisodeSecondDisadvantagePayment { get; set; }
        public decimal? PriceEpisodeSecondEmp1618Pay { get; set; }
        public decimal? PriceEpisodeSecondProv1618Pay { get; set; }
        public decimal? PriceEpisodeSfacontribPct { get; set; }
    }
}
