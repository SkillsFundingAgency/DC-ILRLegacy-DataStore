using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.DataStore.Models;
using ESFA.DC.ILRLegacy.Models;
using ESFA.DC.Logging.Interfaces;
using Microsoft.EntityFrameworkCore;

using ILR1617 = ESFA.DC.ILRLegacy.DataStore.ILR1617EF;
using ILR1718 = ESFA.DC.ILRLegacy.DataStore.ILR1718EF;

namespace ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Repositories
{
    public class FileDetailsRepository
    {
        private readonly ILogger _logger;
        private ILR1617.ILR1617Context _1617Context;
        private ILR1718.ILR1718Context _1718Context;

        public FileDetailsRepository(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<ILRFileDetails> GetLatest1617FileDetailsPerUkPrn(
            int ukPrn,
            ILRConfiguration configuration,
            CancellationToken cancellationToken)
        {
            ILRFileDetails result = null;
            try
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return null;
                }

                var optionsBuilder = new DbContextOptionsBuilder<ILR1617.ILR1617Context>();
                optionsBuilder.UseSqlServer(
                    configuration.ILR1617ConnectionString,
                    providerOptions => providerOptions.CommandTimeout(60));

                using (_1617Context = new ILR1617.ILR1617Context(optionsBuilder.Options))
                {
                    result = await _1617Context.FileDetails
                        .Where(fd => fd.Ukprn == ukPrn)
                        .OrderByDescending(fd => fd.SubmittedTime)
                        .Select(fd => new ILRFileDetails
                        {
                            FileName = fd.Filename,
                            LastSubmission = fd.SubmittedTime
                        }).FirstOrDefaultAsync(cancellationToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get 16/17 file details with ukPrn {ukPrn}", ex);
            }

            return result;
        }

        public async Task<ILRFileDetails> GetLatest1718FileDetailsPerUkPrn(
            int ukPrn,
            ILRConfiguration configuration,
            CancellationToken cancellationToken)
        {
            ILRFileDetails result = null;
            try
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return null;
                }

                var optionsBuilder = new DbContextOptionsBuilder<ILR1718.ILR1718Context>();
                optionsBuilder.UseSqlServer(
                    configuration.ILR1617ConnectionString,
                    providerOptions => providerOptions.CommandTimeout(60));

                using (_1718Context = new ILR1718.ILR1718Context(optionsBuilder.Options))
                {
                    result = await _1718Context.FileDetails
                        .Where(fd => fd.Ukprn == ukPrn)
                        .OrderByDescending(fd => fd.SubmittedTime)
                        .Select(fd => new ILRFileDetails
                        {
                            FileName = fd.Filename,
                            LastSubmission = fd.SubmittedTime
                        }).FirstOrDefaultAsync(cancellationToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get 17/18 file details with ukPrn {ukPrn}", ex);
            }

            return result;
        }
    }
}