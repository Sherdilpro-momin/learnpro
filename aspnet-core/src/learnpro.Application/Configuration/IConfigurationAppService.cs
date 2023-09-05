using System.Threading.Tasks;
using learnpro.Configuration.Dto;

namespace learnpro.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
