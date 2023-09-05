using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using learnpro.Authorization;

namespace learnpro
{
    [DependsOn(
        typeof(learnproCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class learnproApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<learnproAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(learnproApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
