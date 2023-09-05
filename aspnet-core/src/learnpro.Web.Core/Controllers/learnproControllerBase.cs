using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace learnpro.Controllers
{
    public abstract class learnproControllerBase: AbpController
    {
        protected learnproControllerBase()
        {
            LocalizationSourceName = learnproConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
