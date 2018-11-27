using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.DataStore.Models;

namespace ESFA.DC.ILRLegacy.DataStore.Interfaces.Services
{
    public interface IFileDetailsDataService
    {
        Task<IList<ILRFileDetails>> GetFileDetailsForUkPrn(
            int ukPrn,
            CancellationToken cancellationToken);
    }
}