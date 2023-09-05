using Abp.Application.Services;
using learnpro.MultiTenancy.Dto;

namespace learnpro.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

