using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.DataStore.Interfaces;
using ESFA.DC.Logging.Interfaces;
using ILR1617 = ESFA.DC.ILRLegacy.DataStore.ILR1617EF;
using ILR1718 = ESFA.DC.ILRLegacy.DataStore.ILR1718EF;

namespace ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Repositories
{
    public class FM70Repository : IFM70Repository
    {
        private readonly ILogger _logger;
        private readonly ILR1617.ILR1617_Rulebase _1617context;
        private readonly ILR1718.ILR1718_Rulebase _1718context;

        public FM70Repository(ILogger logger)
        {
            _logger = logger;
            _1617context = new ILR1617.ILR1617_Rulebase();
            _1718context = new ILR1718.ILR1718_Rulebase();
        }

        public async Task<IList<ILR1617.ESF_LearningDeliveryDeliverable_PeriodisedValues>> Get1617PeriodisedValues(int ukPrn, CancellationToken cancellationToken)
        {
            IList<ILR1617.ESF_LearningDeliveryDeliverable_PeriodisedValues> values = null;
            try
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return null;
                }

                values = await _1617context.ESF_LearningDeliveryDeliverable_PeriodisedValues
                    .Where(v => v.UKPRN == ukPrn)
                    .ToListAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get 16/17 FM70 periodised values with ukPrn {ukPrn}", ex);
            }

            return values;
        }

        public async Task<IList<ILR1718.ESF_LearningDeliveryDeliverable_PeriodisedValues>> Get1718PeriodisedValues(int ukPrn, CancellationToken cancellationToken)
        {
            IList<ILR1718.ESF_LearningDeliveryDeliverable_PeriodisedValues> values = null;
            try
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return null;
                }

                values = await _1718context.ESF_LearningDeliveryDeliverable_PeriodisedValues
                    .Where(v => v.UKPRN == ukPrn)
                    .ToListAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get 17/18 FM70 periodised values with ukPrn {ukPrn}", ex);
            }

            return values;
        }
    }
}