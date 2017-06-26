using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Tiger.Controllers
{
    public abstract class TigerControllerBase: AbpController
    {
        protected TigerControllerBase()
        {
            LocalizationSourceName = TigerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}