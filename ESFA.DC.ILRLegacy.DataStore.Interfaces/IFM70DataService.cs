using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.Models;

namespace ESFA.DC.ILRLegacy.DataStore.Interfaces
{
    public interface IFM70DataService
    {
        Task<IList<FM70PeriodisedValues>> GetPeriodisedValues(int ukPrn, CancellationToken cancellationToken);
    }
}