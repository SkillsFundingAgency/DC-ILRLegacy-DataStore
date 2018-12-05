using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.DataStore.Models;
using ESFA.DC.ILRLegacy.Models;

namespace ESFA.DC.ILRLegacy.DataStore.Interfaces.Repositories
{
    public interface IFileDetailsRepository
    {
        Task<ILRFileDetails> GetLatest1617FileDetailsPerUkPrn(
            int ukPrn,
            ILRConfiguration configuration,
            CancellationToken cancellationToken);

        Task<ILRFileDetails> GetLatest1718FileDetailsPerUkPrn(
            int ukPrn,
            ILRConfiguration configuration,
            CancellationToken cancellationToken);
    }
}