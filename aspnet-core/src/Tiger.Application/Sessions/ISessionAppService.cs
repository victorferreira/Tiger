using System.Threading.Tasks;
using Abp.Application.Services;
using Tiger.Sessions.Dto;

namespace Tiger.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
