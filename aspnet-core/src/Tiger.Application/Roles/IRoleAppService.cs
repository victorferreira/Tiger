using System.Threading.Tasks;
using Abp.Application.Services;
using Tiger.Roles.Dto;

namespace Tiger.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
