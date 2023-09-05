using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using learnpro.Configuration.Dto;

namespace learnpro.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : learnproAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
