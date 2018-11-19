using System.Collections.Generic;
using ESFA.DC.ILRLegacy.Models;

using ILR1617 = ESFA.DC.ILRLegacy.DataStore.ILR1617EF;
using ILR1718 = ESFA.DC.ILRLegacy.DataStore.ILR1718EF;

namespace ESFA.DC.ILRLegacy.DataStore.Interfaces
{
    public interface IFM70Mapper
    {
        IList<FM70PeriodisedValues> GetPeriodisedValuesFrom1617Entities(
            IList<ILR1617.EsfLearningDeliveryDeliverablePeriodisedValues> entities);

        IList<FM70PeriodisedValues> GetPeriodisedValuesFrom1718Entities(
            IList<ILR1718.EsfLearningDeliveryDeliverablePeriodisedValues> entities);
    }
}