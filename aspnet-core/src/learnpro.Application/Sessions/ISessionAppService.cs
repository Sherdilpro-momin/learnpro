using System.Threading.Tasks;
using Abp.Application.Services;
using learnpro.Sessions.Dto;

namespace learnpro.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
