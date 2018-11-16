using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using ILR1617 = ESFA.DC.ILRLegacy.DataStore.ILR1617EF;
using ILR1718 = ESFA.DC.ILRLegacy.DataStore.ILR1718EF;

namespace ESFA.DC.ILRLegacy.DataStore.Interfaces
{
    public interface IFM70Repository
    {
        Task<IList<ILR1617.ESF_LearningDeliveryDeliverable_PeriodisedValues>> Get1617PeriodisedValues(int ukPrn, CancellationToken cancellationToken);

        Task<IList<ILR1718.ESF_LearningDeliveryDeliverable_PeriodisedValues>> Get1718PeriodisedValues(int ukPrn, CancellationToken cancellationToken);
    }
}