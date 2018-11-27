using Autofac;
using ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Mappers;
using ESFA.DC.ILRLegacy.DataStore.DataAccessLayer.Repositories;
using ESFA.DC.ILRLegacy.DataStore.Interfaces;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Mappers;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Repositories;
using ESFA.DC.ILRLegacy.DataStore.Interfaces.Services;

namespace ESFA.DC.ILRLegacy.DataStore.Services
{
    public class DependencyInjectionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IFileDetailsRepository>().As<FileDetailsRepository>();
            builder.RegisterType<IFM70Repository>().As<FM70Repository>();

            builder.RegisterType<IFM70Mapper>().As<FM70Mapper>();

            builder.RegisterType<IFM70DataService>().As<FM70DataService>();
        }
    }
}
