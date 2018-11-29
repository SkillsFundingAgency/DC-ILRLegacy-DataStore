using Autofac;
using ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Mappers;
using ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Repositories;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Mappers;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Repositories;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Services;

namespace ESFA.DC.ILRLegacy.DataStore.Services
{
    public class DependencyInjectionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FileDetailsRepository>().As<IFileDetailsRepository>();
            builder.RegisterType<FM70Repository>().As<IFM70Repository>();

            builder.RegisterType<FM70Mapper>().As<IFM70Mapper>();

            builder.RegisterType<FM70DataService>().As<IFM70DataService>();
        }
    }
}
