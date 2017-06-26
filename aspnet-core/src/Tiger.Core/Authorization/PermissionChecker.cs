using Abp.Authorization;
using Tiger.Authorization.Roles;
using Tiger.Authorization.Users;

namespace Tiger.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
