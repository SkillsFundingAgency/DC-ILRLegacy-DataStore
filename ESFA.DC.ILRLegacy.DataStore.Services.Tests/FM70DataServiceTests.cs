using System.Threading;
using System.Threading.Tasks;
using Autofac;
using ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Mappers;
using ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Repositories;
using ESFA.DC.ILRLegacy.Models;
using ESFA.DC.Logging.Interfaces;
using Moq;
using Xunit;

namespace ESFA.DC.ILRLegacy.DataStore.Services.Tests
{
    public class FM70DataServiceTests
    {
        [Fact]
        public async Task TestDataServiceDoesntBlowUp()
        {
            var container = new ContainerBuilder();
            container.RegisterModule<DependencyInjectionModule>();

            container.Build();

            const int ukPrn = 10006439;

            var config = new ILRConfiguration
            {
                ILR1617ConnectionString = string.Empty,
                ILR1718ConnectionString = string.Empty
            };

            var repo = new FM70Repository();
            var mapper = new FM70Mapper();
            var dataService = new FM70DataService(repo, mapper, config);

            var result = await dataService.GetPeriodisedValues(ukPrn, CancellationToken.None);
        }
    }
}