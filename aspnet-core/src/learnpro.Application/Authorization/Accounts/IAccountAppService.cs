using System.Threading.Tasks;
using Abp.Application.Services;
using learnpro.Authorization.Accounts.Dto;

namespace learnpro.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
