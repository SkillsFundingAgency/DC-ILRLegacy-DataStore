using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILRLegacy.DataStore.Interfaces;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Mappers;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Repositories;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Services;
using ESFA.DC.ILRLegacy.Models;

namespace ESFA.DC.ILRLegacy.DataStore.Services
{
    public class FM70DataService : IFM70DataService
    {
        private readonly IFM70Repository _repository;
        private readonly IFM70Mapper _mapper;
        private readonly ILRConfiguration _configuration;

        public FM70DataService(
            IFM70Repository repository,
            IFM70Mapper mapper,
            ILRConfiguration configuration)
        {
            _repository = repository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<IList<FM70PeriodisedValues>> GetPeriodisedValues(int ukPrn, CancellationToken cancellationToken)
        {
            var result = new List<FM70PeriodisedValues>();

            var periodisedValues1617 = await _repository.Get1617PeriodisedValues(ukPrn, _configuration, cancellationToken);
            var periodisedValues1718 = await _repository.Get1718PeriodisedValues(ukPrn, _configuration, cancellationToken);

            if (periodisedValues1617 != null && periodisedValues1617.Any())
            {
                result.AddRange(_mapper.GetPeriodisedValuesFrom1617Entities(periodisedValues1617));
            }

            if (periodisedValues1718 != null && periodisedValues1718.Any())
            {
                result.AddRange(_mapper.GetPeriodisedValuesFrom1718Entities(periodisedValues1718));
            }

            return result;
        }
    }
}