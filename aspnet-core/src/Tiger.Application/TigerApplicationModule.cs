using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Tiger.Authorization;

namespace Tiger
{
    [DependsOn(
        typeof(TigerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TigerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TigerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TigerApplicationModule).GetAssembly());
        }
    }
}