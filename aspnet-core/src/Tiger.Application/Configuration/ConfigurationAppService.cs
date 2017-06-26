using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Tiger.Configuration.Dto;

namespace Tiger.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TigerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
