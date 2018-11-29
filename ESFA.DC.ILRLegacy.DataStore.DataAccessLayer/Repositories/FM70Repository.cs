using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Repositories;
using ESFA.DC.ILRLegacy.Models;
using Microsoft.EntityFrameworkCore;

using ILR1617 = ESFA.DC.ILRLegacy.DataStore.ILR1617EF;
using ILR1718 = ESFA.DC.ILRLegacy.DataStore.ILR1718EF;

namespace ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Repositories
{
    public class FM70Repository : IFM70Repository
    {
        // private readonly ILogger _logger;
        private ILR1617.ILR1617Context _1617Context;
        private ILR1718.ILR1718Context _1718Context;

        public async Task<IList<ILR1617.EsfLearningDeliveryDeliverablePeriodisedValues>> Get1617PeriodisedValues(
            int ukPrn,
            ILRConfiguration configuration,
            CancellationToken cancellationToken)
        {
            IList<ILR1617.EsfLearningDeliveryDeliverablePeriodisedValues> values = null;
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
                    values = await _1617Context.EsfLearningDeliveryDeliverablePeriodisedValues
                        .Where(v => v.Ukprn == ukPrn)
                        .ToListAsync(cancellationToken);
                }
            }
            catch (Exception ex)
            {
                // _logger.LogError($"Failed to get 16/17 FM70 periodised values with ukPrn {ukPrn}", ex);
            }

            return values;
        }

        public async Task<IList<ILR1718.EsfLearningDeliveryDeliverablePeriodisedValues>> Get1718PeriodisedValues(
            int ukPrn,
            ILRConfiguration configuration,
            CancellationToken cancellationToken)
        {
            IList<ILR1718.EsfLearningDeliveryDeliverablePeriodisedValues> values = null;
            try
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return null;
                }

                var optionsBuilder = new DbContextOptionsBuilder<ILR1718.ILR1718Context>();
                optionsBuilder.UseSqlServer(
                    configuration.ILR1718ConnectionString,
                    providerOptions => providerOptions.CommandTimeout(60));

                using (_1718Context = new ILR1718.ILR1718Context(optionsBuilder.Options))
                {
                    values = await _1718Context.EsfLearningDeliveryDeliverablePeriodisedValues
                        .Where(v => v.Ukprn == ukPrn)
                        .ToListAsync(cancellationToken);
                }
            }
            catch (Exception ex)
            {
                // _logger.LogError($"Failed to get 17/18 FM70 periodised values with ukPrn {ukPrn}", ex);
            }

            return values;
        }
    }
}