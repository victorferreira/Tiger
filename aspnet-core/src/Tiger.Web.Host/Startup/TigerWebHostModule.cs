using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Tiger.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Tiger.Web.Host.Startup
{
    [DependsOn(
       typeof(TigerWebCoreModule))]
    public class TigerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TigerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TigerWebHostModule).GetAssembly());
        }
    }
}
