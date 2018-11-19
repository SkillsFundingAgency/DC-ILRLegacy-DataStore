using System.Threading;
using System.Threading.Tasks;
//using ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Mappers;
//using ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Repositories;
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
            const int ukPrn = 10006439;
            var logger = new Mock<ILogger>();

            //var repo = new FM70Repository(logger.Object);
            //var mapper = new FM70Mapper();
            //var dataService = new FM70DataService(repo, mapper);

            //var result = await dataService.GetPeriodisedValues(ukPrn, CancellationToken.None);
        }
    }
}