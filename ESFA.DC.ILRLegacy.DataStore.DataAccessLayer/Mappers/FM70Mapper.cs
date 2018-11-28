using System.Collections.Generic;
using System.Linq;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Mappers;
using ESFA.DC.ILRLegacy.Models;

using ILR1617 = ESFA.DC.ILRLegacy.DataStore.ILR1617EF;
using ILR1718 = ESFA.DC.ILRLegacy.DataStore.ILR1718EF;

namespace ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Mappers
{
    public class FM70Mapper : IFM70Mapper
    {
        public IList<FM70PeriodisedValues> GetPeriodisedValuesFrom1617Entities(
            IList<ILR1617.EsfLearningDeliveryDeliverablePeriodisedValues> entities)
        {
            return entities.Select(e => new FM70PeriodisedValues
            {
                FundingYear = 2016,
                UKPRN = e.Ukprn,
                LearnRefNumber = e.LearnRefNumber,
                AimSeqNumber = e.AimSeqNumber,
                DeliverableCode = e.DeliverableCode,
                AttributeName = e.AttributeName,
                Period1 = e.Period1,
                Period2 = e.Period2,
                Period3 = e.Period3,
                Period4 = e.Period4,
                Period5 = e.Period5,
                Period6 = e.Period6,
                Period7 = e.Period7,
                Period8 = e.Period8,
                Period9 = e.Period9,
                Period10 = e.Period10,
                Period11 = e.Period11,
                Period12 = e.Period12
            }).ToList();
        }

        public IList<FM70PeriodisedValues> GetPeriodisedValuesFrom1718Entities(
            IList<ILR1718.EsfLearningDeliveryDeliverablePeriodisedValues> entities)
        {
            return entities.Select(e => new FM70PeriodisedValues
            {
                FundingYear = 2017,
                UKPRN = e.Ukprn,
                LearnRefNumber = e.LearnRefNumber,
                AimSeqNumber = e.AimSeqNumber,
                DeliverableCode = e.DeliverableCode,
                AttributeName = e.AttributeName,
                Period1 = e.Period1,
                Period2 = e.Period2,
                Period3 = e.Period3,
                Period4 = e.Period4,
                Period5 = e.Period5,
                Period6 = e.Period6,
                Period7 = e.Period7,
                Period8 = e.Period8,
                Period9 = e.Period9,
                Period10 = e.Period10,
                Period11 = e.Period11,
                Period12 = e.Period12
            }).ToList();
        }
    }
}