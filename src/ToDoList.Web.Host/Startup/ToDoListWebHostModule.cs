using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ToDoList.Configuration;

namespace ToDoList.Web.Host.Startup
{
    [DependsOn(
       typeof(ToDoListWebCoreModule))]
    public class ToDoListWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ToDoListWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ToDoListWebHostModule).GetAssembly());
        }
    }
}
