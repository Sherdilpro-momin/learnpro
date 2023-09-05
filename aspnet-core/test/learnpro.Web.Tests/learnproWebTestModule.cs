using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using learnpro.EntityFrameworkCore;
using learnpro.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace learnpro.Web.Tests
{
    [DependsOn(
        typeof(learnproWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class learnproWebTestModule : AbpModule
    {
        public learnproWebTestModule(learnproEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(learnproWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(learnproWebMvcModule).Assembly);
        }
    }
}