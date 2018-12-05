using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.Models;
using ILR1617 = ESFA.DC.ILRLegacy.DataStore.ILR1617EF;
using ILR1718 = ESFA.DC.ILRLegacy.DataStore.ILR1718EF;

namespace ESFA.DC.ILRLegacy.DataStore.Interfaces.Repositories
{
    public interface IFM70Repository
    {
        Task<IList<ILR1617.EsfLearningDeliveryDeliverablePeriodisedValues>> Get1617PeriodisedValues(
            int ukPrn,
            ILRConfiguration configuration,
            CancellationToken cancellationToken);

        Task<IList<ILR1718.EsfLearningDeliveryDeliverablePeriodisedValues>> Get1718PeriodisedValues(
            int ukPrn,
            ILRConfiguration configuration,
            CancellationToken cancellationToken);
    }
}