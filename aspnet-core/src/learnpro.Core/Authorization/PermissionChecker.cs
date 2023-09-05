using Abp.Authorization;
using learnpro.Authorization.Roles;
using learnpro.Authorization.Users;

namespace learnpro.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
