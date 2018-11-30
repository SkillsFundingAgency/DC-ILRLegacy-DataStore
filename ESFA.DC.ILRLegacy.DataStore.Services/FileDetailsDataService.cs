using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Repositories;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Services;
using ESFA.DC.ILRLegacy.DataStore.Models;
using ESFA.DC.ILRLegacy.Models;

namespace ESFA.DC.ILRLegacy.DataStore.Services
{
    public class FileDetailsDataService : IFileDetailsDataService
    {
        private readonly IFileDetailsRepository _repository;
        private readonly ILRConfiguration _configuration;

        public FileDetailsDataService(
            IFileDetailsRepository repository,
            ILRConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        public async Task<IList<ILRFileDetails>> GetFileDetailsForUkPrn(
            int ukPrn,
            CancellationToken cancellationToken)
        {
            var result = new List<ILRFileDetails>();

            var fileDetails1617 =
                await _repository.GetLatest1617FileDetailsPerUkPrn(ukPrn, _configuration, cancellationToken);

            var fileDetails1718 =
                await _repository.GetLatest1718FileDetailsPerUkPrn(ukPrn, _configuration, cancellationToken);

            if (fileDetails1617 != null)
            {
                result.Add(fileDetails1617);
            }

            if (fileDetails1718 != null)
            {
                result.Add(fileDetails1718);
            }

            return result;
        }
    }
}