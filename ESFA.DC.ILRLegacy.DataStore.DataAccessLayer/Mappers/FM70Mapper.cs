using System.Collections.Generic;
using System.Linq;
using ESFA.DC.ILRLegacy.DataStore.Interfaces;
using ESFA.DC.ILRLegacy.Models;

using ILR1617 = ESFA.DC.ILRLegacy.DataStore.ILR1617EF;
using ILR1718 = ESFA.DC.ILRLegacy.DataStore.ILR1718EF;

namespace ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Mappers
{
    public class FM70Mapper : IFM70Mapper
    {
        public IList<FM70PeriodisedValues> GetPeriodisedValuesFrom1617Entities(
            IList<ILR1617.ESF_LearningDeliveryDeliverable_PeriodisedValues> entities)
        {
            return entities.Select( e => new FM70PeriodisedValues
            {
                UKPRN = e.UKPRN,
                LearnRefNumber = e.LearnRefNumber,
                AimSeqNumber = e.AimSeqNumber,
                DeliverableCode = e.DeliverableCode,
                AttributeName = e.AttributeName,
                Period1 = e.Period_1,
                Period2 = e.Period_2,
                Period3 = e.Period_3,
                Period4 = e.Period_4,
                Period5 = e.Period_5,
                Period6 = e.Period_6,
                Period7 = e.Period_7,
                Period8 = e.Period_8,
                Period9 = e.Period_9,
                Period10 = e.Period_10,
                Period11 = e.Period_11,
                Period12 = e.Period_12
            }).ToList();
        }

        public IList<FM70PeriodisedValues> GetPeriodisedValuesFrom1718Entities(
            IList<ILR1718.ESF_LearningDeliveryDeliverable_PeriodisedValues> entities)
        {
            return entities.Select(e => new FM70PeriodisedValues
            {
                UKPRN = e.UKPRN,
                LearnRefNumber = e.LearnRefNumber,
                AimSeqNumber = e.AimSeqNumber,
                DeliverableCode = e.DeliverableCode,
                AttributeName = e.AttributeName,
                Period1 = e.Period_1,
                Period2 = e.Period_2,
                Period3 = e.Period_3,
                Period4 = e.Period_4,
                Period5 = e.Period_5,
                Period6 = e.Period_6,
                Period7 = e.Period_7,
                Period8 = e.Period_8,
                Period9 = e.Period_9,
                Period10 = e.Period_10,
                Period11 = e.Period_11,
                Period12 = e.Period_12
            }).ToList();
        }
    }
}