using System.Threading.Tasks;
using Tiger.Configuration.Dto;

namespace Tiger.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}